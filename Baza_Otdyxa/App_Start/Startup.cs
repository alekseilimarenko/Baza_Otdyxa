using Baza_Otdyxa;
using Baza_Otdyxa.BLL.Interfaces;
using Baza_Otdyxa.BLL.Services;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Baza_Otdyxa
{
    public class Startup
    {
        readonly IServiceCreator _serviceCreator = new ServiceCreator();

        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(CreateCustomerService);
            app.CreatePerOwinContext(CreateOrderService);
            app.CreatePerOwinContext(CreateRoleService);
            app.CreatePerOwinContext(CreateRoomFotoService);
            app.CreatePerOwinContext(CreateRoomService);
            app.CreatePerOwinContext(CreateUserService);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private CustomerService CreateCustomerService()
        {
            return _serviceCreator.CreateCustomerService("DefaultConnection");
        }

        private OrderService CreateOrderService()
        {
            return _serviceCreator.CreateOrderService("DefaultConnection");
        }

        private RoomFotoService CreateRoomFotoService()
        {
            return _serviceCreator.CreateRoomFotoService("DefaultConnection");
        }

        private RoomService CreateRoomService()
        {
            return _serviceCreator.CreateRoomService("DefaultConnection");
        }

        private IRoleService CreateRoleService()
        {
            return _serviceCreator.CreateRoleService("DefaultConnection");
        }

        private IUserService CreateUserService()
        {
            return _serviceCreator.CreateUserService("DefaultConnection");
        }
    }
}