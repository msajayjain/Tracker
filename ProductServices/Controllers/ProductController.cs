using Microsoft.AspNetCore.Mvc;
using ProductServices.Database.Entity;
using ProductServices.Database;
using Microsoft.EntityFrameworkCore;

// Ajay Jain1 added more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductServices.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/productlist")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        DatabaseContext db;
        public ProductController()
        {
            db = new DatabaseContext();


        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<DBproductlist> Get()
        {
            return db.Products.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public DBproductlist Get(int id)
        {
            return db.Products.Find(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] DBproductlist model)
        {
            try
            {
                db.Products.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
