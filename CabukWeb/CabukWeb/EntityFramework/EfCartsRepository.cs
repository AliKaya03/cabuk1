﻿using CabukWeb.Abstract;
using CabukWeb.Models;
using CabukWeb.Repositories;

namespace CabukWeb.EntityFramework
{
    public class EfCartsRepository:GenericRepository<Carts>,ICartsDal
    {

    }
}
