using Jelewry_Store.Entities;
using Jelewry_Store.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jelewry_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        readonly BranchServices branchServices;
        public BranchController()
        {
            branchServices = new BranchServices();
        }
        // GET: api/<BranchController>
        [HttpGet]
        public ActionResult<List<Branch>> Get()
        {
            List<Branch> branches = branchServices.GetAllBranches();
            if (branches == null)
                return NotFound();
            return branches;
        }

        // GET api/<BranchController>/5
        [HttpGet("{codeBranch}")]
        public ActionResult<Branch> Get(int codeBranch)
        {
            if(codeBranch < 0) return BadRequest();
            Branch branch= branchServices.GetBranchByCode(codeBranch);
            if(branch == null)
                return NotFound();
            return branch;
        }

        // POST api/<BranchController>
        [HttpPost]
        public ActionResult Post([FromBody] Branch branch)
        {
            branchServices.AddBranch(branch);
            return Ok();
        }

        // PUT api/<BranchController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int codeBranch, [FromBody] Branch branch)
        {
            if (codeBranch < 0) return BadRequest();
            Branch s = branchServices.GetBranchByCode(codeBranch);
            if (s == null)
                return NotFound();
            branchServices.PutBranch(codeBranch, branch);
            return Ok();
        }

        // DELETE api/<BranchController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int codeBranch)
        {
            if (codeBranch < 0) return BadRequest();
            Branch s = branchServices.GetBranchByCode(codeBranch);
            if (s == null)
                return NotFound();
            branchServices.DeleteSending(codeBranch);
            return Ok();
        }
    }
}
