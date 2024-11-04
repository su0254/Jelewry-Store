using Jelewry_Store.Entities;
using Jelewry_Store.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jelewry_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : ControllerBase
    {
        readonly ProductServices productServices;
        public ProductController()
        {
            productServices = new ProductServices();
        }
        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            List<Product> products = productServices.GetAllProducts();
            if(products == null)
                return NotFound();
            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{makat}")]
        public ActionResult<Product> Get(string makat)
        {
            Product product=productServices.GetProductById(makat);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            productServices.PostProduct(product);
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{makat}")]
        public ActionResult Put(string makat, [FromBody] Product product)
        {
            Product p = productServices.GetProductById(makat);
            if(p==null)
                return NotFound();
            productServices.PutProduct(makat, p);
            return Ok(p);

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{makat}")]
        public ActionResult Delete(string makat)
        {
            Product p = productServices.GetProductById(makat);
            if (p == null)
                return NotFound();
            productServices.DeleteProduct(makat);
            return Ok(p);
        }
    }
}
