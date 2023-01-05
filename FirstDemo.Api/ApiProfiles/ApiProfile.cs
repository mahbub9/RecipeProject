using AutoMapper;
using FirstDemo.Api.Models;
using FirstDemo.Domain.BusinessObjects;

namespace FirstDemo.Api.ApiProfiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<RecipeDto, RecipeModel>().ReverseMap();
            CreateMap<FirstDemo.Domain.BusinessObjects.Ingrediant, FirstDemo.Api.Models.Ingrediant>().ReverseMap();
        }
    }
}
