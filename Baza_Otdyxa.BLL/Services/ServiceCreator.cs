using Baza_Otdyxa.BLL.Interfaces;
using Baza_Otdyxa.DAL.Repositories;

namespace Baza_Otdyxa.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IRoleService CreateRoleService(string connection)
        {
            return new RoleService(new IdentityUnitOfWork(connection));
        }

        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }

        public OrderService CreateOrderService(string connection)
        {
            return new OrderService(new IdentityUnitOfWork(connection));
        }

        public CustomerService CreateCustomerService(string connection)
        {
            return new CustomerService(new IdentityUnitOfWork(connection));
        }

        public RoomFotoService CreateRoomFotoService(string connection)
        {
            return new RoomFotoService(new IdentityUnitOfWork(connection));
        }

        public RoomService CreateRoomService(string connection)
        {
            return new RoomService(new IdentityUnitOfWork(connection));
        }
    }
}