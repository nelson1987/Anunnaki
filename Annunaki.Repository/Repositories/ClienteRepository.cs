using Annunaki.Repository.Interfaces;
using Anunnaki.Domain.Entities;
using System;

namespace Annunaki.Repository.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public override void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public override void FindByFilter(Func<Cliente> filter)
        {
            throw new NotImplementedException();
        }

        public override void FindById(int idEntity)
        {
            throw new NotImplementedException();
        }

        public override void Insert(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
