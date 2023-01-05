using FirstDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Entities
{
    public class Ingredient : IEntity<int>
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<Recipe> Receipes { get; set; }
    }
}
