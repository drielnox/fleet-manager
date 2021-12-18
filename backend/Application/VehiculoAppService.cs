using AutoMapper;
using Data;
using Entities;
using Messaging;
using Messaging.Responses;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class VehiculoAppService : IVehiculoAppService
    {
        private readonly IDbContextFactory<FleetDbContext> _contextFactory;

        public IMapper Mapper { get; }

        public VehiculoAppService(IDbContextFactory<FleetDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
            Mapper = AutoMapperConfiguration.Configuration.CreateMapper();

            using (var ctx = _contextFactory.CreateDbContext())
            {
                ctx.Database.EnsureCreated();
            }
        }

        public VehiculoViewModel Actualizar(VehiculoViewModel vehiculo)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                var result = ctx.Vehiculos.SingleOrDefault(x => x.Identificador == vehiculo.Identificador);
                if (vehiculo is null)
                {
                    throw new ApplicationException("El vehiculo a actualizar no existe.");
                }

                result.Marca = vehiculo.Marca;
                result.Modelo = vehiculo.Modelo;
                result.Ruedas = vehiculo.Ruedas;
                result.NumeroChasis = vehiculo.NumeroChasis;
                result.SumarKilometraje(vehiculo.KilometrosRecorridos - result.KilometrosRecorridos);

                ctx.SaveChanges();

                return Mapper.Map<VehiculoViewModel>(result);
            }
        }

        public void Borrar(VehiculoViewModel vehiculo)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                var result = ctx.Vehiculos.SingleOrDefault(x => x.Identificador == vehiculo.Identificador);
                if (result is null)
                {
                    throw new ApplicationException("El vehiculo a borrar no existe.");
                }

                ctx.Vehiculos.Remove(result);

                ctx.SaveChanges();
            }
        }

        public void Crear(VehiculoViewModel vehiculo)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                var nuevo = Mapper.Map<Vehiculo>(vehiculo);

                ctx.Vehiculos.Add(nuevo);

                ctx.SaveChanges();
            }
        }

        public VehiculoViewModel Obtener(int id)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                var result = ctx.Vehiculos.Single(x => x.Identificador == id);

                return Mapper.Map<VehiculoViewModel>(result);
            }
        }

        public IEnumerable<VehiculoViewModel> ObtenerTodos()
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                var result = ctx.Vehiculos.ToList();

                return Mapper.Map<List<VehiculoViewModel>>(result);
            }
        }
    }
}