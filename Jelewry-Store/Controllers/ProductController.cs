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
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{makat}")]
        public ActionResult<Product> Get(string makat)
        {
            if(makat == null) return NotFound();    
            Product product=productServices.GetProductById(makat);
            if (product == null)
                return NotFound();
            return product;
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Product product)
        {
            productServices.PostProduct(product);
            return true;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{makat}")]
        public ActionResult<bool> Put(string makat, [FromBody] Product product)
        {
            if(makat == null) return NotFound();
            Product p = productServices.GetProductById(makat);
            if(p==null)
                return NotFound();
            productServices.PutProduct(makat, product);
            return true;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{makat}")]
        public ActionResult<bool> Delete(string makat)
        {
            if(makat == null) return NotFound();
            Product p = productServices.GetProductById(makat);
            if (p == null)
                return NotFound();
            productServices.DeleteProduct(makat);
            return true;
        }
    }
}
