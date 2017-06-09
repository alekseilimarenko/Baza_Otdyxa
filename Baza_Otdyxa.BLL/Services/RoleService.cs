using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.DTO;
using Baza_Otdyxa.BLL.Infrastucture;
using Baza_Otdyxa.BLL.Interfaces;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Interfaces;
using Baza_Otdyxa.DAL.Repositories;

namespace Baza_Otdyxa.BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _efUnitOfWork;

        public RoleService(IdentityUnitOfWork efUnitOfWork)
        {
            _efUnitOfWork = efUnitOfWork;
        }

        public async Task<OperationDetails> Create(string roleName)
        {
            var role = await _efUnitOfWork.RoleManager.FindByNameAsync(roleName);
            if (role != null)
            {
                return new OperationDetails(false, "Роль с таким названием уже существует", roleName);
            }
            else
            {
                await _efUnitOfWork.RoleManager.CreateAsync(
                    new ApplicationRole { Name = roleName });
                return new OperationDetails(true, "Роль успешно сохранена", "");
            }
        }

        public Task<OperationDetails> Edit(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Delete(string roleName)
        {
            throw new NotImplementedException();
        }

        public List<RoleModel> Select()
        {
            var roles = _efUnitOfWork.RoleManager.Roles
                .Select(catalog => new RoleModel
                {
                    Id = catalog.Id,
                    Name = catalog.Name,
                    Users = catalog.Users
                })
                .AsNoTracking()
                .ToList();

            return roles;
        }

        public void Dispose()
        {
            _efUnitOfWork.Dispose();
        }
    }
}