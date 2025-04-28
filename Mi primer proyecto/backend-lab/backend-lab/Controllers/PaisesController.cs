using backend_lab.Handlers;
using backend_lab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisHandler _paisesHandler;
        public PaisesController()
        { 
            _paisesHandler = new PaisHandler();
        }
        [HttpGet]
        public List<PaisModel> Get()
        {
            var paises = _paisesHandler.ObtenerPaises();
            return paises;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> CrearPais(PaisModel pais)
        {
            try
            {
                if (pais == null)
                {
                    return BadRequest();
                }
                PaisHandler paisHandler = new PaisHandler();
                var resultado = paisHandler.CrearPais(pais);
                return new JsonResult(resultado);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Error creando país");
            }
        }
    }
}
