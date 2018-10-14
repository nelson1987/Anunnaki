using Anunnaki.Application.Interfaces;
using Anunnaki.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Anunnaki.Presentation.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Post(
            [FromBody] CadastroClienteModel modelo, 
            [FromServices] IClienteApplicationService service)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                service.CadastrarCliente(modelo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}