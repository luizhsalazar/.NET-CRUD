 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.ViewModels
{
    public class ClientAddressViewModel
    {
        public ClientAddressViewModel()
        {
            ClientId = Guid.NewGuid();
            //AddressId = Guid.NewGuid();
        }

        // Client
        // Data annotations allow print messages in View

        [Key]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        public string Document { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Birthday { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; set; }

        // Address

        //public Guid AddressId { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Logradouro")]
        //public string Location { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Número")]
        //public string Number { get; set; }


    }
}
