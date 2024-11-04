using Jelewry_Store.Entities;
using Jelewry_Store.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jelewry_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly OrderServices orderServices;
        public OrderController()
        {
            orderServices = new OrderServices();
        }
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            List<Order> orders = orderServices.GetAllOrders();
            if (orders == null)
                return NotFound();
            return Ok(orders);
        }

        // GET api/<OrderController>/5
        [HttpGet("{orderCode}")]
        public ActionResult<Order> Get(int orderCode)
        {
            Order order = orderServices.GetOrderById(orderCode);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            orderServices.AddOrder(order);
            return Ok();
        }

        // PUT api/<OrderController>/5
        [HttpPut("{orderCode}")]
        public ActionResult Put(int orderCode, [FromBody] Order order)
        {
            Order o = orderServices.GetOrderById(orderCode);
            if (order == null)
                return NotFound();
            orderServices.PutOrder(orderCode, order);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{orderCode}")]
        public ActionResult Delete(int orderCode)
        {
            Order o = orderServices.GetOrderById(orderCode);
            if (o == null)
                return NotFound();
            orderServices.DeleteOrder(orderCode);
            return Ok();
        }
    }
}
