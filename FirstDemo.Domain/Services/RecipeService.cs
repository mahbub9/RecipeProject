using AutoMapper;
using FirstDemo.Domain.BusinessObjects;
using FirstDemo.Domain.Entities;
using FirstDemo.Domain.Exceptions;
using FirstDemo.Domain.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Services
{
    public class RecipeService : IReceipeService
    {
        private readonly IRecipeUnitOfWork _recipeUnitOfWork;
        private readonly IMapper _mapper;

        public RecipeService(IRecipeUnitOfWork trainingUnitOfWork,
            IMapper mapper)
        {
            _recipeUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void CreateRecipe(RecipeDto receipeDto)
        {
            if (receipeDto == null)
                throw new InvalidParameterException("Recipe was not provided");

            _recipeUnitOfWork.Receipes.Add(_mapper.Map<Recipe>(receipeDto));
            _recipeUnitOfWork.Save();
        }

        public IList<RecipeDto> GetAllRecipe()
        {
            var recipeEntities = _recipeUnitOfWork.Receipes.GetAll();
            var recipes = new List<RecipeDto>();

            foreach (var entity in recipeEntities)
            {
                var recipe = _mapper.Map<RecipeDto>(entity);
                recipes.Add(recipe);
            }

            return recipes;
        }

        public RecipeDto GetRecipe(int id)
        {
            var recipeEntity = _recipeUnitOfWork.Receipes.GetById(id);

            if (recipeEntity == null) return null;

            return _mapper.Map<RecipeDto>(recipeEntity);
        }
    }
}
