using CRUD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Tests.Entity.Specification
{
    [TestClass]
    class DocumentSpecificationTest
    {
        [TestMethod]
        public void DocumentSpecification_isSatisfied_True()
        {
            // Arrange
            var client = new Client
            {
                Document = "01217041060"
            };

            // Act
            // var specReturn = new ClientDeveTerCpfValidoSpecification().IsSatisfiedBy(client);

            // Assert
            //Assert.IsTrue(specReturn);
        }
    }
}
