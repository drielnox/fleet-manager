using AutoMapper;
using Entities;

namespace WebAPI.ViewModels
{
    public class VehiculoProfile : Profile
    {
        public VehiculoProfile()
        {
            CreateMap<Vehiculo, VehiculoViewModel>();
        }
    }
}
