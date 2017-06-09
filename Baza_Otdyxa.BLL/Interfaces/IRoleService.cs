using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.DTO;
using Baza_Otdyxa.BLL.Infrastucture;

namespace Baza_Otdyxa.BLL.Interfaces
{
    public interface IRoleService :IDisposable
    {
        Task<OperationDetails> Create(string roleName);

        Task<OperationDetails> Edit(string roleName);

        Task<OperationDetails> Delete(string roleName);

        List<RoleModel> Select();
    }
}