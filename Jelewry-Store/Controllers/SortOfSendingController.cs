using Jelewry_Store.Entities;
using Jelewry_Store.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jelewry_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortOfSendingController : ControllerBase
    {
        readonly SortOfSendingServices sendings;
        public SortOfSendingController()
        {
            sendings = new SortOfSendingServices();
        }
        // GET: api/<SortOfSendingController>
        [HttpGet]
        public ActionResult<List<SortOfSending>> Get()
        {
            List<SortOfSending> sortsOfSending = sendings.GetAllSendings();
            if (sendings == null)
                return NotFound();
            return sortsOfSending;
        }

        // GET api/<SortOfSendingController>/5
        [HttpGet("{sendingCode}")]
        public ActionResult<SortOfSending> Get(string sendingCode)
        {
            SortOfSending sending = sendings.GetSendingByCode(sendingCode);
            if (sending == null)
                return NotFound();
            return sending;
        }

        // POST api/<SortOfSendingController>
        [HttpPost]
        public ActionResult Post([FromBody] SortOfSending sending)
        {
            sendings.AddSending(sending);
            return Ok();
        }

        // PUT api/<SortOfSendingController>/5
        [HttpPut("{sendingCode}")]
        public ActionResult Put(string sendingCode, [FromBody] SortOfSending sending)
        {
            SortOfSending s = sendings.GetSendingByCode(sendingCode);
            if(s == null)
                return NotFound();
            sendings.PutSending(sendingCode, s);
            return Ok();
        }

        // DELETE api/<SortOfSendingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string sendingCode)
        {
            SortOfSending sending = sendings.GetSendingByCode(sendingCode);
            if(sending == null)
                return NotFound();
            sendings.DeleteSending(sendingCode);
            return Ok();
        }
    }
}
