using AutoMapper;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly FleetDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<VehiculoController> _logger;

        public VehiculoController(FleetDbContext context, IMapper mapper, ILogger<VehiculoController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;

            _context.Database.EnsureCreated();
        }

        [HttpGet()]

        public IEnumerable<VehiculoViewModel> GetAll()
        {
            var result = _context.Vehiculos.ToList();
            return _mapper.Map<IEnumerable<VehiculoViewModel>>(result);
        }

        [HttpGet("{id:int}")]

        public VehiculoViewModel GetOne(int id)
        {
            var result = _context.Vehiculos.SingleOrDefault(x => x.Identificador == id);
            return _mapper.Map<VehiculoViewModel>(result);
        }
    }
}