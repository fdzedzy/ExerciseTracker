using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ExerciseTracker.Model;
using ExerciseTracker.Model.DbConfig;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ExerciseTracker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ExerciseTrackerDbContext _dbContext;

        public UserController(ExerciseTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        // GET api/user
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var user = _dbContext.Users.First();
            return new JsonResult(user);
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            return new JsonResult(user);
        }

        // POST api/user
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var user = JsonConvert.DeserializeObject<User>(value);

            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            user = JsonConvert.DeserializeObject<User>(value);

            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(user);
        }
    }
}
