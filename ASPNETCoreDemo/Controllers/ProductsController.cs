using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDemo.Data;
using ASPNETCoreDemo.Models;

namespace ASPNETCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : GenericController<Product, EFCoreProductRepository>
    {
        public ProductsController(EFCoreProductRepository repository) : base(repository)
        {

        }
    }
}
