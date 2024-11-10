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
            return orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{orderCode}")]
        public ActionResult<Order> Get(int orderCode)
        {
            if (orderCode < 0) return BadRequest();
            Order order = orderServices.GetOrderById(orderCode);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            orderServices.AddOrder(order);
            return true;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{orderCode}")]
        public ActionResult<bool> Put(int orderCode, [FromBody] Order order)
        {
            if (orderCode < 0) return BadRequest();
            Order o = orderServices.GetOrderById(orderCode);
            if (order == null)
                return NotFound();
            orderServices.PutOrder(orderCode, order);
            return true;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{orderCode}")]
        public ActionResult<bool> Delete(int orderCode)
        {
            if (orderCode < 0) return BadRequest();
            Order o = orderServices.GetOrderById(orderCode);
            if (o == null)
                return NotFound();
            orderServices.DeleteOrder(orderCode);
            return true;
        }
    }
}
