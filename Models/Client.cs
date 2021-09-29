using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Models
{
    public class Client : IdentityUser
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public int CPF { get; set; }
        
        public string Phone { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string AddressId { get; set; }
        
        public List<Address> Address { get; set; }

    }
}
