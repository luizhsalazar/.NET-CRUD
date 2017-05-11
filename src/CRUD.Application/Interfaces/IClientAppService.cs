using CRUD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        // All these can access ViewModel methods and are accessible to be rendered in View

        ClientAddressViewModel Add(ClientAddressViewModel clientAddressViewModel);

        ClientViewModel GetById(Guid id);

        IEnumerable<ClientViewModel> GetAll();

        ClientViewModel GetByDocument(string document);

        ClientViewModel GetByEmail(string email);

        ClientViewModel Update(ClientViewModel clientViewModel);

        void Remove(Guid id);
    }
}
