using ExpensesApp.Application.Services;
using ExpensesApp.Domain;
using ExpensesApp.Infrastructure.Data;
using ExpensesApp.Infrastructure.Data.Repositorys;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpensesApp.Infrastructure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ServiceUser CreateService()
        {
            ExpensesContext db = new ExpensesContext();
            UserRepository repo = new UserRepository(db);
            ServiceUser service = new ServiceUser(repo);
            return service;
        } 
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost(Name = "Register")]
        public ActionResult Register([FromBody] User user)
        {
            var servicio = CreateService();
            servicio.RegisterUser(user);
            return Ok();
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
