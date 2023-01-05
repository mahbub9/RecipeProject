using FirstDemo.Data;
using FirstDemo.Domain.Contexts;
using FirstDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Repositories
{
    

    public class IngrediantRepository : Repository<Ingredient, int>,
        IIngrediantRepository
    {
        public IngrediantRepository(IRecipeContext context)
            : base((DbContext)context)
        {
        }
    }
}
