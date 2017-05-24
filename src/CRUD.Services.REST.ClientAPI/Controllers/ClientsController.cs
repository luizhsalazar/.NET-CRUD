using CRUD.Application.Interfaces;
using CRUD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Services.REST.ClientAPI.Controllers
{
    public class ClientsController : ApiController
    {
        private readonly IClientAppService _clientAppService;

        public ClientsController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        // GET: api/Clients
        public IEnumerable<ClientViewModel> Get()
        {
            return _clientAppService.GetAll();
        }

        // GET: api/Clients/5
        public ClientViewModel Get(Guid id)
        {
            return _clientAppService.GetById(id);
        }

        // POST: api/Clients
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clients/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clients/5
        public void Delete(int id)
        {
        }
    }
}
