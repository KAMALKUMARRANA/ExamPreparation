using EPMS.API.Data;
using EPMS.API.Models;
using EPMS.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EPMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataBaseContext dataBaseContext;
        private readonly IUserRepository userRepository;

        /*  private readonly IUserRepository userRepository;
private readonly PemsdbContext pemsdbContext;

public UserController(IUserRepository userRepository,PemsdbContext pemsdbContext)
{
this.userRepository = userRepository;
this.pemsdbContext = pemsdbContext;
}*/
        public UserController(DataBaseContext dataBaseContext, IUserRepository userRepository)
        {
            this.dataBaseContext = dataBaseContext;
            this.userRepository = userRepository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {

            return Ok(await userRepository.GetUser());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
