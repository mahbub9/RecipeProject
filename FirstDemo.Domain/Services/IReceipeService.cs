using FirstDemo.Domain.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Services
{
    public interface IReceipeService
    {
        void CreateRecipe(RecipeDto receipeDto);
        IList<RecipeDto> GetAllRecipe();
        RecipeDto GetRecipe(int id);
    }
}
