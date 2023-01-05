using FirstDemo.Data;
using FirstDemo.Domain.Contexts;
using FirstDemo.Domain.Entities;
using FirstDemo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.UnitOfWorks
{
    public class RecipeUnitOfWork : UnitOfWork, IRecipeUnitOfWork
    {        
        public IReceipeRepository Receipes { get; private set; }
        public IIngrediantRepository Ingrediants { get; private set; }

        public RecipeUnitOfWork(IRecipeContext context,            
            IReceipeRepository receipes,
            IIngrediantRepository ingrediants
            ) : base((DbContext)context)
        {            
            Receipes = receipes;
            Ingrediants = ingrediants;
        }
    }
}
