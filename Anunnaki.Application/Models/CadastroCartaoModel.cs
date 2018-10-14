namespace Anunnaki.Application.Models
{
    public class CadastroCartaoModel
    {
        public int IdCliente { get; set; }
        public string NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public string BandeiraCartao { get; set; }
        public string ValidadeCartao { get; set; }
        public string CvvCartao { get; set; }
    }
}
