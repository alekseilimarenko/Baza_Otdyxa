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
    public class OrderRepository : IRepository<OrderCatalog>
    {
        private readonly ApplicationContext _database;

        public DbSet<OrderCatalog> DbSet { get; }

        public OrderRepository(ApplicationContext db)
        {
            _database = db;
        }

        public void Create(OrderCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string iid)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderCatalog> Select(string id)
        {
            throw new NotImplementedException();
        }

        public OrderCatalog GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderCatalog> Find(Func<OrderCatalog, bool> predicate)
        {
            return _database.OrderCatalogs.Where(predicate).ToList();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
