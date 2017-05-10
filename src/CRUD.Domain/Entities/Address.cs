using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Address
    {
        public Address()
        {
            AddressId = Guid.NewGuid();
        }

        public Guid AddressId { get; set; }

        public string Location { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        // Relation many addresses to many client
        public Guid ClientId { get; set; }

        // Map Address to Client
        public virtual Client Client { get; set; }

    }
}
