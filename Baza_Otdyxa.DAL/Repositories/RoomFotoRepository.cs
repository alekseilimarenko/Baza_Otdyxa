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
    public class RoomFotoRepository : IRepository<RoomFotoCatalog>
    {
        private readonly ApplicationContext _database;

        public DbSet<RoomFotoCatalog> DbSet { get; }

        public RoomFotoRepository(ApplicationContext db)
        {
            _database = db;
        }

        public void Create(RoomFotoCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Update(RoomFotoCatalog item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string iid)
        {
            throw new NotImplementedException();
        }

        public IQueryable<RoomFotoCatalog> Select(string id)
        {
            throw new NotImplementedException();
        }

        public RoomFotoCatalog GetById(string id)
        {
            return _database.RoomFotoCatalogs.Find(id);
        }

        public IEnumerable<RoomFotoCatalog> Find(Func<RoomFotoCatalog, bool> predicate)
        {
            return _database.RoomFotoCatalogs.Where(predicate).ToList();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
