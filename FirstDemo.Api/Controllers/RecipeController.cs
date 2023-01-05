using AutoMapper;
using FirstDemo.Api.Models;
using FirstDemo.Domain.BusinessObjects;
using FirstDemo.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {

        private IReceipeService _recipeService;
        private readonly IMapper _mapper;
        public RecipeController(IReceipeService recipeService,
            IMapper mapper)
        {
            _recipeService = recipeService;
            _mapper = mapper;
        }

        [HttpPost]
        public void Post( RecipeModel model)
        {
            _recipeService.CreateRecipe(_mapper.Map<RecipeDto>(model));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_recipeService.GetRecipe(id));
        }

        [HttpGet]
        public object GetAll()
        {
            return Ok(_recipeService.GetAllRecipe());
        }
    }
}
