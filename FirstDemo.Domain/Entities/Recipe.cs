using FirstDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Entities
{
    public class Recipe: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
