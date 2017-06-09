using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.DTO;
using Baza_Otdyxa.BLL.Infrastucture;
using Baza_Otdyxa.BLL.Interfaces;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Identity;
using Baza_Otdyxa.DAL.Interfaces;
using Baza_Otdyxa.DAL.Repositories;
using Microsoft.AspNet.Identity;

namespace Baza_Otdyxa.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _efUnitOfWork;

        public UserService(IdentityUnitOfWork uow)
        {
            _efUnitOfWork = uow;
        }

        public async Task<OperationDetails> Create(UserModel userDto)
        {
            ApplicationUser user = await _efUnitOfWork.UserManager.FindByEmailAsync(userDto.Email);
            if (user == null)
            {
                user = new ApplicationUser { Email = userDto.Email, UserName = userDto.Email };
                var result = await _efUnitOfWork.UserManager.CreateAsync(user, userDto.Password);
                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.FirstOrDefault(), "");
                // добавляем роль
                await _efUnitOfWork.UserManager.AddToRoleAsync(user.Id, userDto.Role);
                // создаем профиль клиента
                ClientProfile clientProfile = new ClientProfile
                {
                    Id = user.Id,
                    DateTimeCreate = userDto.DateTimeCreate,
                    DateTimeChange = userDto.DateTimeChange,
                    Address = userDto.Address,
                    Name = userDto.Name
                };
                _efUnitOfWork.ClientManager.Create(clientProfile);
                await _efUnitOfWork.SaveAsync();
                return new OperationDetails(true, "Регистрация успешно пройдена", "");
            }
            else
            {
                return new OperationDetails(false, "Пользователь с таким логином уже существует", "Email");
            }
        }

        public async Task<ClaimsIdentity> Authenticate(UserModel userDto)
        {
            ClaimsIdentity claim = null;
            // находим пользователя
            ApplicationUser user = await _efUnitOfWork.UserManager.FindAsync(userDto.Email, userDto.Password);
            // авторизуем его и возвращаем объект ClaimsIdentity
            if (user != null)
                claim = await _efUnitOfWork.UserManager.CreateIdentityAsync(user,
                                            DefaultAuthenticationTypes.ApplicationCookie);
            return claim;
        }

        // начальная инициализация бд
        public async Task SetInitialData(UserModel adminDto, List<string> roles)
        {
            foreach (string roleName in roles)
            {
                var role = await _efUnitOfWork.RoleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    role = new ApplicationRole { Name = roleName };
                    await _efUnitOfWork.RoleManager.CreateAsync(role);
                }
            }
            await Create(adminDto);
        }

        public List<UserModel> GetUserList()
        {
            List<UserModel> listUserDto = new List<UserModel>();

            foreach (ApplicationUser user in _efUnitOfWork.UserManager.Users)
            {
                listUserDto.Add(new UserModel
                {
                    Id = user.Id,
                    DateTimeCreate = user.ClientProfile.DateTimeCreate,
                    DateTimeChange = user.ClientProfile.DateTimeChange,
                    UserName = user.UserName,
                    Email = user.Email
                });
            }
            return listUserDto;
        }

        public async Task<bool> IsUserAdmin(UserModel user)
        {
            ApplicationUser userFromDb = await _efUnitOfWork.UserManager.FindByEmailAsync(user.Email);

            return await _efUnitOfWork.UserManager.IsInRoleAsync(userFromDb.Id, "admin");
        }

        public string FindById(string id)
        {
            ApplicationUserManager mgr = _efUnitOfWork.UserManager;

            return mgr.FindById(id).UserName;
        }

        public void Dispose()
        {
            _efUnitOfWork.Dispose();
        }
    }
}
