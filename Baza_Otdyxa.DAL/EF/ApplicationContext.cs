using System.Data.Entity;
using Baza_Otdyxa.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Baza_Otdyxa.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() { }

        public ApplicationContext(string connectionString) 
            : base(connectionString) { }

        public DbSet<ClientProfile> ClientProfiles { get; set; }

        public DbSet<CustomerCatalog> CustomerCatalogs { get; set; }

        public DbSet<OrderCatalog> OrderCatalogs { get; set; }

        public DbSet<RoomCatalog> RoomCatalogs { get; set; }

        public DbSet<RoomFotoCatalog> RoomFotoCatalogs { get; set; }
    }
}
