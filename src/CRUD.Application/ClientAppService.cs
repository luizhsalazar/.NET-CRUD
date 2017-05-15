using CRUD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Application.ViewModels;
using CRUD.Infra.Data.Repository;
using AutoMapper;
using CRUD.Domain.Entities;

namespace CRUD.Application
{
    public class ClientAppService : IClientAppService
    {
        private readonly IClientAppService _clientService;

        public ClientAppService(IClientAppService clientService)
        {
            _clientService = clientService;
        }

        public ClientAddressViewModel Add(ClientAddressViewModel clientAddressViewModel)
        {
            // I can't "add" a ViewModel object straight to the repository, then a Mapper schema between ViewModel and Model must be defined
            var client = Mapper.Map<Client>(clientAddressViewModel);
            var address = Mapper.Map<Address>(clientAddressViewModel);

            client.Addresses.Add(address);
            client.CreatedAt = DateTime.Now;
            //_clientService.Add(client);

            return clientAddressViewModel;
        }

        public void Dispose()
        {
            _clientService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ClientViewModel> GetAll()
        {
            return null; // Mapper.Map<IEnumerable<ClientViewModel>>(_clientRepository.GetAll());
        }

        public ClientViewModel GetByDocument(string document)
        {
            return Mapper.Map<ClientViewModel>(_clientService.GetByDocument(document));
        }

        public ClientViewModel GetByEmail(string email)
        {
            return Mapper.Map<ClientViewModel>(_clientService.GetByEmail(email));
        }

        public ClientViewModel GetById(Guid id)
        {
            return Mapper.Map<ClientViewModel>(_clientService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _clientService.Remove(id);
        }

        public ClientViewModel Update(ClientViewModel clientViewModel)
        {
            var client = Mapper.Map<Client>(clientViewModel);
            // _clientService.Update(client);

            return clientViewModel;
        }
    }
}
