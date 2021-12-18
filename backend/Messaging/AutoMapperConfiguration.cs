using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Messaging.Profiles;

namespace Messaging
{
    public static class AutoMapperConfiguration
    {
        public readonly static MapperConfiguration Configuration;

        static AutoMapperConfiguration()
        {
            Configuration = new MapperConfiguration(cfg => {
                cfg.AddCollectionMappers();
                cfg.AddProfile(new VehiculoProfile());
            });
        }
    }
}
