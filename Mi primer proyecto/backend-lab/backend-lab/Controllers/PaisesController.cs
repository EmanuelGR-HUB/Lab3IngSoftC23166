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
    }
}
