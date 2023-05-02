using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using UDPBroadcastAPI.Models;
using UDPBroadcastAPI.Repo;

namespace UDPBroadcastAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TemperatureController : Controller
    {
        // GET: api/<TemperatureController>
        public TemperatureRepository _repo;
        public TemperatureController(TemperatureRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public List<Temperature> GetAll()
        {
            return _repo.GetAll();
        }

        // GET api/<TemperatureController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TemperatureController>
        [HttpPost]
        public void Post([FromBody]Temperature temperature) 
        {
            _repo.Add(temperature);
        }

        // PUT api/<TemperatureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TemperatureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
