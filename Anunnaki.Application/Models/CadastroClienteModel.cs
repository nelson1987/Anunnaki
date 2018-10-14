using System.ComponentModel.DataAnnotations;

namespace Anunnaki.Application.Models
{
    public class CadastroClienteModel
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
