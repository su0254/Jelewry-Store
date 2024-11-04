using Jelewry_Store.Services;
using Jelewry_Store.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jelewry_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserServices services;

        public UserController()
        {
            services = new UserServices();
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            List<User> users = services.GetAllUser();
            if(users==null)
                return NotFound();
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{Makat}")]
        public ActionResult<User> Get(string id)
        {
            User user = services.GetUserById(id);
            if(user==null) return NotFound();
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            services.PostUser(user);
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] User user)
        {
            User u = services.GetUserById(id);
            if(u==null) 
                return NotFound();
            services.PutUser(id, user);
            return Ok();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            User u = services.GetUserById(id);
            if (u == null) 
                return NotFound();
            services.DeleteUser(id);
            return Ok();
        }
    }
}
