using Microsoft.AspNetCore.Mvc;
using WebApplication1.BookModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext databaseContext = new FunnyDatabaseContext();
            return Ok(databaseContext.Books.ToList());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keresettvicc = (from x in context.Books
                                where x.Id == id
                                select x).FirstOrDefault();
            return Ok(keresettvicc);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Book ujBook)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Books.Add(ujBook);
            context.SaveChanges();
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
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var törledőKönyv = (from x in context.Books
                                where x.Id == id
                                select x).FirstOrDefault();
            context.Remove(törledőKönyv);
            context.SaveChanges();

        }
    }
}
