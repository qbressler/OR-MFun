﻿using ORMNorthwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNorthwind.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAllProducts();

        string GetProductNameById(int id);
    }
}
