using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equipe2_PneuStore.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Logradouro Obrigatório")]
        public string Street { get; set; }

        [Required(ErrorMessage = "CEP Obrigatório")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Número Obrigatório")]
        public string Number1 { get; set; }
        
        public string Number2 { get; set; }
        
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "Cidade Obrigatório")]
        public string City { get; set; }

        [Required(ErrorMessage = "Estado Obrigatório")]
        public string State { get; set; }

        public List<Client> Client { get; set; }

        public List<Partner> Partner { get; set; }
    }
}
