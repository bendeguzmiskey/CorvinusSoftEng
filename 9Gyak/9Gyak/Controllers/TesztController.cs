using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _9Gyak.Controllers
{
    [Route("api/miskey")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        // GET: api/<TesztController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Tárgy> tárgyak = new List<Tárgy>();
            tárgyak.Add(
                new Tárgy()
                {
                    Név = "Matek",
                    IsBoring = true,
                    Kredit = 3
                }
                );
            tárgyak.Add(
                new Tárgy()
                {
                    Név = "Angol",
                    IsBoring = false,
                    Kredit = 10,
                    Average = 3.14m
                }
                );


            return Ok( tárgyak );
        }

        // GET api/<TesztController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TesztController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TesztController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TesztController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
