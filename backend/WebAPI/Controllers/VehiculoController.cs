using Application;
using Messaging.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoAppService _appService;
        private readonly ILogger<VehiculoController> _logger;

        public VehiculoController(IVehiculoAppService appService, ILogger<VehiculoController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        [HttpGet]

        public ActionResult<IEnumerable<VehiculoViewModel>> GetAll()
        {
            var result = _appService.ObtenerTodos();
            return Ok(result);
        }

        [HttpGet("{id:int}")]

        public ActionResult<VehiculoViewModel> GetOne(int id)
        {
            var result = _appService.Obtener(id);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult Create(VehiculoViewModel vehiculo)
        {
            _appService.Crear(vehiculo);
            return Ok();
        }

        [HttpPost]
        public ActionResult<VehiculoViewModel> Update(VehiculoViewModel vehiculo)
        {
            var result = _appService.Actualizar(vehiculo);
            return Ok(result);
        }

        [HttpDelete]
        public ActionResult Delete(VehiculoViewModel vehiculo)
        {
            _appService.Borrar(vehiculo);
            return Ok();
        }
    }
}