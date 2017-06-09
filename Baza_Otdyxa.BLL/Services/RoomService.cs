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
    public class RoomService : ITableService<RoomModel>, IDisposable
    {
        private readonly IUnitOfWork _efUnitOfWork;

        public RoomService(IdentityUnitOfWork iuow)
        {
            _efUnitOfWork = iuow;
        }

        public Task<OperationDetails> Create(RoomModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Update(RoomModel item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Delete(RoomModel item)
        {
            throw new NotImplementedException();
        }

        public List<RoomModel> SelectList(string id)
        {
            throw new NotImplementedException();
        }

        public RoomModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomModel> Find(Func<RoomModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _efUnitOfWork.Dispose();
        }
    }
}
