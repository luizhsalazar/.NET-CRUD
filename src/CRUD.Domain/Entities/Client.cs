using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Client
    {
        public Client()
        {
            ClientId = Guid.NewGuid();
        }

        public Guid ClientId { get; set; }

        public string Name { get; set; }
        public string Document { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }

        // "virtual" activate Lazy Loading
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
