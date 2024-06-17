using BoletoBus.Infraestructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbTestController : ControllerBase
    {
        private readonly BoletoBusContext _context;
        private readonly ILogger<DbTestController> _logger;

        public DbTestController(BoletoBusContext context, ILogger<DbTestController> logger)
        {
            _context = context;
            _logger = logger;

        }


        // GET: api/<DbTestController>
        [HttpGet]
        public IActionResult TestDatabaseConnection()
        {
            try
            {
                // Intentar obtener un asiento para verificar la conexión a la base de datos
                var asiento = _context.Asiento.FirstOrDefault();
                return Ok("Connection successful!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database connection failed");
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }

        // GET api/<DbTestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DbTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DbTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DbTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
