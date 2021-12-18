using Messaging.Responses;

namespace Application
{
    public interface IVehiculoAppService
    {
        IEnumerable<VehiculoViewModel> ObtenerTodos();
        VehiculoViewModel Obtener(int id);
        void Crear(VehiculoViewModel vehiculo);
        VehiculoViewModel Actualizar(VehiculoViewModel vehiculo);
        void Borrar(VehiculoViewModel vehiculo);
    }
}