using FirstDemo.Data;
using FirstDemo.Domain.Contexts;
using FirstDemo.Domain.Entities;
using FirstDemo.Domain.Repositories;

namespace FirstDemo.Domain.UnitOfWorks
{
    public interface IRecipeUnitOfWork : IUnitOfWork
    {       
        IReceipeRepository  Receipes { get; }
        IIngrediantRepository  Ingrediants { get; }
    }
}