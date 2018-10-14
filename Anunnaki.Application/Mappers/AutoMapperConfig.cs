using AutoMapper;

namespace Anunnaki.Application.Mappers
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EntityToModelMap>();
                cfg.AddProfile<ModelToEntityMap>();
            });
        }
    }
}
