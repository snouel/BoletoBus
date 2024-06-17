using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsientoController : ControllerBase
    {
        private readonly IAsientoRepository _asientoRepository;

        public AsientoController(IAsientoRepository asientoRepository)
        {
            this._asientoRepository = asientoRepository;
        }

        // GET: api/<AsientoController>
        [HttpGet]
        public async Task<IActionResult> GetAsientos()
        {
            var asientos = await this._asientoRepository.GetAll(cd => !cd.Deleted);
            return Ok(asientos);
        }

        [HttpGet("testconnection")]
        public IActionResult TestConnection()
        {
            try
            {
                _asientoRepository.TestConnection();
                return Ok("Connection successful!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Connection failed: {ex.Message}");
            }
        }


        // GET api/<AsientoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AsientoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AsientoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsientoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
