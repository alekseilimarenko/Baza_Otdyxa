using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.DAL.EF;
using Baza_Otdyxa.DAL.Entities;
using Baza_Otdyxa.DAL.Interfaces;

namespace Baza_Otdyxa.DAL.Repositories
{
    public class RoomRepository : IRepository<RoomCatalog>
    {
        private readonly ApplicationContext _database;

        public DbSet<RoomCatalog> DbSet { get; }

        public RoomRepository(ApplicationContext db)
        {
            _database = db;
        }

        public void Create(RoomCatalog item)
        {
            _database.RoomCatalogs.Add(item);
            _database.SaveChanges();
        }

        public void Update(RoomCatalog item)
        {
            _database.RoomCatalogs.AddOrUpdate(item);
            _database.SaveChanges();
        }

        public void Delete(string id)
        {
            var room = _database.RoomCatalogs.Find(id);
            if (room != null)
            {
                _database.RoomCatalogs.Remove(room);
            }
        }

        public IQueryable<RoomCatalog> Select(string id)
        {
            throw new NotImplementedException();
        }

        public RoomCatalog GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomCatalog> Find(Func<RoomCatalog, bool> predicate)
        {
            return _database.RoomCatalogs.Where(predicate).ToList();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
