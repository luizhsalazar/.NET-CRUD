using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel()
        {
            ClientId = Guid.NewGuid();
            Addresses = new List<AddressViewModel>();
        }

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

        public ICollection<AddressViewModel> Addresses { get; set; }
    }
}
