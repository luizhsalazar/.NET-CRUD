using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Tests.Entity.Validation
{
    [TestClass]
    class ClientAbleToBeRegisteredTest
    {
        [TestMethod]
        public void ClientAble_IsValid_True()
        {
            // Arrange
            var client = new Client()
            {
                Document = "01217041060",
                Email = "luizhsalazar@gmail.com"
            };

            // Act
            // using lib "rhinomocks" to mock database persistence
            var repo = MockRepository.GenerateStub<IClientRepository>();

            repo.Stub(s => s.GetByDocument(client.Document)).Return(null);
            repo.Stub(s => s.GetByEmail(client.Email)).Return(null);

            // var validationReturn = new ClientAbleToBeRegistered(repo).Validate(client);

            // Assert
            // Assert.IsTrue(validationReturn.IsValid);
        }
    }
}
