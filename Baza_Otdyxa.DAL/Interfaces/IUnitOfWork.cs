using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Identity;
using Baza_Otdyxa.DAL.Repositories;

namespace Baza_Otdyxa.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }

        ApplicationRoleManager RoleManager { get; }

        IClientManager ClientManager { get; }

        IRepository<OrderCatalog> OrderCatalogRepository { get; }
       
        IRepository<RoomCatalog> RoomCatalogRepository { get; }

        IRepository<RoomFotoCatalog> RoomFotoCatalogRepository { get; }

        IRepository<CustomerCatalog> CustomerCatalogRepository { get; }

        Task SaveAsync();
    }
}
