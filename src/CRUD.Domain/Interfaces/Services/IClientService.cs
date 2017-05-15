using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Interfaces.Services
{
    public interface IClientService : IDisposable
    {
        Client Add(Client client);

        Client GetById(Guid id);

        IEnumerable<Client> GetAll();

        Client GetByDocument(string document);

        Client GetByEmail(string email);

        Client Update(Client client);

        void Remove(Guid id);
    }
}
