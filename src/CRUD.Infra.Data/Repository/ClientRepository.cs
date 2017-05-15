using System;
using System.Collections.Generic;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repository;
using System.Linq;
using CRUD.Infra.Data.Context;

namespace CRUD.Infra.Data.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(CRUDContext context)
            :base(context)
        {

        }

        public IEnumerable<Client> GetActives()
        {
            return Search(c => c.Active);
        }

        public Client GetByDocument(string document)
        {
            return Search(c => c.Document == document).FirstOrDefault();
        }

        public Client GetByEmail(string email)
        {
            return Search(c => c.Email == email).FirstOrDefault();
        }

        public override IEnumerable<Client> GetAll()
        {
            // Override method from base method
            return Db.Clients.OrderBy(c => c.CreatedAt);
        }

        public override void Remove(Guid id)
        {
            // Instead of remove Client only set as "inactive"
            var client = GetById(id);
            client.Active = false;
            Update(client);
        }
    }
}
