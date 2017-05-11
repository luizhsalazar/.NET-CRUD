using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {
            AddressId = Guid.NewGuid();
        }

        [Key]
        public Guid AddressId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número")]
        public string Number { get; set; }

        [ScaffoldColumn(false)]
        public Guid ClientId { get; set; }

    }
}
