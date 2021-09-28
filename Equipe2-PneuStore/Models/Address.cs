using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equipe2_PneuStore.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        //Número do endereço
        public string Number1 { get; set; }
        //Complemeto do endereço
        public string Number2 { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Client Client { get; set; }
    }
}
