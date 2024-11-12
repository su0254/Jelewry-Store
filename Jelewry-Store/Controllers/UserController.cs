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
        readonly UserServices _services;

        public UserController(UserServices userServices)
        {
            _services = userServices;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            List<User> users = _services.GetAllUser();
            if(users==null)
                return NotFound();
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{tz}")]
        public ActionResult<User> Get(string tz)
        {
            if(tz==null) BadRequest();
            User user = _services.GetUserById(tz);
            if(user==null) return NotFound();
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            _services.PostUser(user);
            return true;
        }

        // PUT api/<UserController>/5
        [HttpPut("{tz}")]
        public ActionResult<bool> Put(string tz, [FromBody] User user)
        {
            if(tz==null) BadRequest();
            User u = _services.GetUserById(tz);
            if(u==null) 
                return NotFound(false);
            _services.PutUser(tz, user);
            return true;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{tz}")]
        public ActionResult<bool> Delete(string tz)
        {
            if (tz==null) BadRequest();
            User u = _services.GetUserById(tz);
            if (u == null) 
                return NotFound(false);
            _services.DeleteUser(tz);
            return true;
        }
    }
}
