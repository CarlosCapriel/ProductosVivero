using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductosVivero.Model;
using ProductosVivero.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IserviceItems _serviceItems;
        private readonly IConfiguration _conf;

        public ProductsController(IserviceItems serviceItems, IConfiguration conf)
        {
            _serviceItems = serviceItems;
            _conf = conf;
        }

        [HttpGet("{email}")]
        public ActionResult<Items[]> Get(string email)
        {
            return Ok(_serviceItems.getProducts(email));
        }

        [HttpPost("{email}")]
        public ActionResult<Items> Post([FromRoute] string email, [FromBody] Items item)
        {
            return _serviceItems.saveProduct(item, email);
        }
    }
}
