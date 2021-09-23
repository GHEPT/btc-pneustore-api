using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TyreId { get; set; }        
        public Tyre Tyre { get; set; }
    }
}
