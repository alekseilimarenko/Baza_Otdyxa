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
    public class RoomFotoService : ITableService<RoomFotoModel>, IDisposable
    {
        private readonly IUnitOfWork _efUnitOfWork;

        public RoomFotoService(IdentityUnitOfWork iuow)
        {
            _efUnitOfWork = iuow;
        }

        public Task<OperationDetails> Create(RoomFotoModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Update(RoomFotoModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Delete(RoomFotoModel item)
        {
            throw new NotImplementedException();
        }

        public List<RoomFotoModel> SelectList(string id)
        {
            throw new NotImplementedException();
        }

        public RoomFotoModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomFotoModel> Find(Func<RoomFotoModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _efUnitOfWork.Dispose();
        }
    }
}
