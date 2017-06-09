using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.EF;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Interfaces;

namespace Baza_Otdyxa.DAL.Repositories
{
    public class ClientManager : IClientManager
    {
        private ApplicationContext Database { get; }

        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Edit(ClientProfile item)
        {
            Database.ClientProfiles.AddOrUpdate(item);
            Database.SaveChanges();
        }

        public void Delete(ClientProfile item)
        {
            Database.ClientProfiles.Remove(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
