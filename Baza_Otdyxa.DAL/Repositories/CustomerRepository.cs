using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.EF;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Interfaces;

namespace Baza_Otdyxa.DAL.Repositories
{
    public class CustomerRepository : IRepository<CustomerCatalog>
    {
        private readonly ApplicationContext _database;

        public DbSet<CustomerCatalog> DbSet { get; }

        public CustomerRepository(ApplicationContext db)
        {
            _database = db;
        }

        public void Create(CustomerCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string iid)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CustomerCatalog> Select(string id)
        {
            throw new NotImplementedException();
        }

        public CustomerCatalog GetById(string id)
        {
            return _database.CustomerCatalogs.Find(id);
        }

        public IEnumerable<CustomerCatalog> Find(Func<CustomerCatalog, bool> predicate)
        {
            return _database.CustomerCatalogs.Where(predicate).ToList();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
