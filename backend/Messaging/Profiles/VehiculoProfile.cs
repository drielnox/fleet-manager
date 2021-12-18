using AutoMapper;
using Entities;
using Messaging.Responses;

namespace Messaging.Profiles
{
    public class VehiculoProfile : Profile
    {
        public VehiculoProfile()
        {
            CreateMap<Vehiculo, VehiculoViewModel>();
            CreateMap<VehiculoViewModel, Vehiculo>();
        }
    }
}
