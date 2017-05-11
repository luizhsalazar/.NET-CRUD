using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Interfaces.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByDocument(string document);
        Client GetByEmail(string email);
        IEnumerable<Client> GetActives();
    }
}
