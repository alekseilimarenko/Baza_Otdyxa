using System;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.EF;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Identity;
using Baza_Otdyxa.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Baza_Otdyxa.DAL.Repositories
{
    public class IdentityUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _database;

        private readonly ApplicationUserManager _userManager;
        private readonly ApplicationRoleManager _roleManager;
        private readonly IClientManager _clientManager;

        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;
        private readonly RoomFotoRepository _roomFotoRepository;
        private readonly RoomRepository _roomRepository;

        public IdentityUnitOfWork(string connectionString)
        {
            _database = new ApplicationContext(connectionString);

            _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(_database));
            _roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(_database)); 
            _clientManager = new ClientManager(_database);

            _customerRepository = new CustomerRepository(_database);
            _orderRepository = new OrderRepository(_database);
            _roomFotoRepository = new RoomFotoRepository(_database);
            _roomRepository = new RoomRepository(_database);
        }

        public ApplicationUserManager UserManager => _userManager;
        public ApplicationRoleManager RoleManager => _roleManager;
        public IClientManager ClientManager => _clientManager;

        public IRepository<OrderCatalog> OrderCatalogRepository => _orderRepository;
        public IRepository<RoomCatalog> RoomCatalogRepository => _roomRepository;
        public IRepository<RoomFotoCatalog> RoomFotoCatalogRepository => _roomFotoRepository;
        public IRepository<CustomerCatalog> CustomerCatalogRepository => _customerRepository;

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                if (disposing)
                {
                    _userManager.Dispose();
                    _roleManager.Dispose();
                    _clientManager.Dispose();

                    _customerRepository.Dispose();
                    _orderRepository.Dispose();
                    _roomFotoRepository.Dispose();
                    _roomRepository.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
