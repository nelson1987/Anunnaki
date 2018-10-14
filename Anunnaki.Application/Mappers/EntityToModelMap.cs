using Anunnaki.Application.Models;
using Anunnaki.Domain.Entities;
using AutoMapper;

namespace Anunnaki.Application.Mappers
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Cliente, CadastroClienteModel>();
        }
    }
}
