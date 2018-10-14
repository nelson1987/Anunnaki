using Anunnaki.Application.Models;
using Anunnaki.Domain.Entities;
using AutoMapper;

namespace Anunnaki.Application.Mappers
{
    public class ModelToEntityMap : Profile
    {
        //construtor
        public ModelToEntityMap()
        {
            CreateMap<CadastroClienteModel, Cliente>();
        }
    }
}
