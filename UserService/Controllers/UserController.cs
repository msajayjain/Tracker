using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/userlist")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //[Route("UserList")]
        //[HttpGet]   
        
        DatabaseContext db;
        public UserController() 
        {
            db= new DatabaseContext(); 


        }
        // GET: api/<UserController>
        [HttpGet]

        public async Task <IActionResult> Get()
        {
            //return db.Ajay.ToList();
            return Ok("All Good");
        }
        //public IEnumerable<DBUserDetails> Get()
        //{

            //return db.Ajay.ToList();
          //  return "hello";
        //}

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public DBUserDetails Get(int id)
        {
            return db.Ajay.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] DBUserDetails model)
        {
            try
            {
                db.Ajay.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created,model);
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }
            

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
