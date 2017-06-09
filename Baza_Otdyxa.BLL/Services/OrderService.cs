using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_Otdyxa.BLL.DTO;
using Baza_Otdyxa.BLL.Infrastucture;
using Baza_Otdyxa.BLL.Interfaces;
using Baza_Otdyxa.DAL.Interfaces;
using Baza_Otdyxa.DAL.Repositories;

namespace Baza_Otdyxa.BLL.Services
{
    public class OrderService : ITableService<OrderModel>, IDisposable
    {
        private readonly IUnitOfWork _efUnitOfWork;

        public OrderService(IdentityUnitOfWork iuow)
        {
            _efUnitOfWork = iuow;
        }

        public Task<OperationDetails> Create(OrderModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Update(OrderModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Delete(OrderModel item)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> SelectList(string id)
        {
            throw new NotImplementedException();
        }

        public OrderModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderModel> Find(Func<OrderModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _efUnitOfWork.Dispose();
        }
    }
}
