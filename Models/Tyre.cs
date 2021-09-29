using System.Collections.Generic;

namespace ApiPneuStore.Models
{
    public class Tyre
    {
        public int Id { get; set; }
      
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public string Image { get; set; }
        
        public double Price { get; set; }
        
        public string Description { get; set; }
        
        public List<Category> Category { get; set; }
    }
}
