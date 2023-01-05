using System.Collections.Generic;

namespace FirstDemo.Api.Models
{
    public class RecipeModel
    {
        public string Name { get; set; }
        public ICollection<Ingrediant> Ingrediants { get; set; }
    }
}
