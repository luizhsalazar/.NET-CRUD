using CRUD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repository;

namespace CRUD.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client client)
        {
            return _clientRepository.Add(client);
        }

        public void Dispose()
        {
            _clientRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetByDocument(string document)
        {
            return _clientRepository.GetByDocument(document);
        }

        public Client GetByEmail(string email)
        {
            return _clientRepository.GetByEmail(email);
        }

        public Client GetById(Guid id)
        {
            return _clientRepository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _clientRepository.Remove(id);
        }

        public Client Update(Client client)
        {
            return _clientRepository.Update(client);
        }
    }
}
