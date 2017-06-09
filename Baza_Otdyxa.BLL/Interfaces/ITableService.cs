using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.Infrastucture;

namespace Baza_Otdyxa.BLL.Interfaces
{
    public interface ITableService<T> where T : class
    {
        Task<OperationDetails> Create(T item);
        Task<OperationDetails> Update(T item);
        Task<OperationDetails> Delete(T item);
        List<T> SelectList(string id);
        T GetById(string id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
    }
}