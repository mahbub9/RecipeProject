using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = FirstDemo.Domain.Entities;
using BO = FirstDemo.Domain.BusinessObjects;

namespace FirstDemo.Domain.Profiles
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<EO.Recipe, BO.RecipeDto>().ReverseMap();
        }
    }
}
