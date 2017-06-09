using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.DTO;
using Baza_Otdyxa.BLL.Infrastucture;

namespace Baza_Otdyxa.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserModel userDto);

        Task<ClaimsIdentity> Authenticate(UserModel userDto);

        List<UserModel> GetUserList();

        Task<bool> IsUserAdmin(UserModel user);

        Task SetInitialData(UserModel adminDto, List<string> roles);

        string FindById(string id);
    }
}
