using Annunaki.Service.Interfaces;
using Anunnaki.Application.Interfaces;
using Anunnaki.Application.Models;
using Anunnaki.Domain.Entities;
using System;

namespace Anunnaki.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteService _service;

        public ClienteApplicationService(IClienteService service)
        {
            _service = service;
        }

        public void CadastrarCliente(CadastroClienteModel cliente)
        {
            try
            {
                var clienteCadastro = AutoMapper.Mapper.Map<Cliente>(cliente);
                _service.Cadastrar(clienteCadastro);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
