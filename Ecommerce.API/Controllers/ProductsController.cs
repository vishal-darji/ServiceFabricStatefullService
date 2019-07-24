using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Client;

namespace Ecommerce.API.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ProductsController : ControllerBase
   {
      



        [HttpGet]
        public async Task<IEnumerable<ApiProduct>> GetAsync()
        {
            return new ApiProduct[] { new ApiProduct { Id = Guid.NewGuid(), Description = "test" } };
        }

     
   }
}