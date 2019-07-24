﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ProductCatelog.Model
{
    public interface IProductRepository
    {
         Task<IEnumerable<Product>> GetAllProducts();

         Task AddProduct(Product Product);


    }
}
