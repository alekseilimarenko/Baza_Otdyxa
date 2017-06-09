using Baza_Otdyxa.BLL.Services;

namespace Baza_Otdyxa.BLL.Interfaces
{
    public interface IServiceCreator
    {
        IRoleService CreateRoleService(string connection);

        IUserService CreateUserService(string connection);

        OrderService CreateOrderService(string connection);

        CustomerService CreateCustomerService(string connection);

        RoomFotoService CreateRoomFotoService(string connection);

        RoomService CreateRoomService(string connection);
    }
}
