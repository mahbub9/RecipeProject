﻿using FirstDemo.Data;
using FirstDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Repositories
{
    

    public interface IReceipeRepository : IRepository<Recipe, int>
    {
    }
}
