using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.Entities;

namespace Baza_Otdyxa.DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create(ClientProfile item);
        void Edit(ClientProfile item);
        void Delete(ClientProfile item);
    }
}
