using FinalZhGyakorlas.F1Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalZhGyakorlas.Controllers
{
    [Route("api/f1")]
    [ApiController]
    public class F1Controller : ControllerBase
    {
        // GET: api/<F1Controller>
        [HttpGet]
        public IActionResult Get()
        {
            F1DriversContext context = new F1DriversContext();
            return Ok(context.F1Drivers.ToList());
        }

        // GET api/<F1Controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            F1DriversContext context = new F1DriversContext();
            var driver = (from x in context.F1Drivers
                                where x.DriverId == id
                                select x).FirstOrDefault();
            return Ok(driver);
        }

        // POST api/<F1Controller>
        [HttpPost]
        public void Post([FromBody] F1Driver newdriver)
        {
            F1DriversContext context = new F1DriversContext();
            context.F1Drivers.Add(newdriver);
            context.SaveChanges();
        }

        // PUT api/<F1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<F1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            F1DriversContext context = new F1DriversContext();
            var deleteDriver = (from x in context.F1Drivers
                                where x.DriverId == id
                                select x).FirstOrDefault();
            context.Remove(deleteDriver);
            context.SaveChanges();
        }
    }
}
