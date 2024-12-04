using Microsoft.AspNetCore.Mvc;
using ZH_Gyak_1.BookModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZH_Gyak_1.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Books.ToList());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keresett = (from x in context.Books
                            where x.Id == id
                            select x).FirstOrDefault();
            if (keresett == null) 
            {
                return NotFound("Nincs ilyen");
            }
            return Ok(keresett);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book value)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var modositando = (from x in context.Books
                               where x.Id == id
                               select x).FirstOrDefault();
            if (modositando == null)
            {
                return NotFound("Nincs ilyen");
            }

            modositando.Title = value.Title;
            modositando.Author = value.Author;
            modositando.Year = value.Year;
            modositando.Genre  = value.Genre;
            modositando.IsAvailable = value.IsAvailable;

            context.SaveChanges();
            return Ok("Sikeres modositas");
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var torlendo = (from x in context.Books
                            where x.Id == id
                            select x).FirstOrDefault();
            if (torlendo == null)
            {
                return NotFound("Nincs ilyen");
            }

            context.Books.Remove(torlendo);
            context.SaveChanges();
            return Ok("Sikeres torles");
        }
    }
}
