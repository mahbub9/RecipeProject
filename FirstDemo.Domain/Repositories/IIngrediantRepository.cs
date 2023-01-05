using FirstDemo.Data;
using FirstDemo.Domain.Contexts;
using FirstDemo.Domain.Entities;

namespace FirstDemo.Domain.Repositories
{
    public interface IIngrediantRepository : IRepository<Ingredient, int>
    {
    }
}
