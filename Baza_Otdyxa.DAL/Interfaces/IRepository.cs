using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Baza_Otdyxa.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> DbSet { get; }

        void Create(T item);

        void Update(T item);

        void Delete(string iid);

        IQueryable<T> Select(string id);

        T GetById(string id);

        IEnumerable<T> Find(Func<T, bool> predicate);
    }
}
