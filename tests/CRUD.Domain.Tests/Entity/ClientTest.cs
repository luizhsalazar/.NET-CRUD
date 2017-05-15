using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD.Domain.Entities;

namespace CRUD.Domain.Tests
{
    [TestClass]
    public class ClientTest
    {
        // AAA -> Arrange, Act, Assert

        [TestMethod]
        public void Client_ConsistencyValid_True()
        {
            // Arrange
            var client = new Client()
            {
                Document = "01217041060",
                Email = "luizhsalazar@gmail.com",
                Birthday = new DateTime(1989, 01, 01)
            };

            // Act
            // var result = client.IsValid();

            // Assert
            // Assert.IsTrue(result);
        }
    }
}
