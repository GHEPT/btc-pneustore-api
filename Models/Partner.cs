using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equipe2_PneuStore.Models
{
    public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Logradouro Obrigatório")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required(ErrorMessage = "CEP Obrigatório")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Cidade Obrigatório")]
        public string City { get; set; }

        [Required(ErrorMessage = "Estado Obrigatório")]
        public string State { get; set; }
        public int Note { get; set; }

    }
}
