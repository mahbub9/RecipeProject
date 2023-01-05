using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.BusinessObjects
{
    public class RecipeDto
    {
        public string Name { get; set; }
        public ICollection<Ingrediant> Ingrediants { get; set; }
    }
}
