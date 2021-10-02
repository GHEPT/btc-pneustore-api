using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equipe2_PneuStore.Models
{
    public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int AddressId { get; set; }

        public List<Address> Address { get; set; }

    }
}
