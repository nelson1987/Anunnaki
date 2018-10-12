public class Cartao
{
    public int IdCartao { get; set; }
    public int IdCliente { get; set; }
    public string Numero { get; set; }
    public string Bandeira { get; set; }
    public string Validade { get; set; }
    public decimal Limite { get; set; }
    public Cliente Cliente { get; set; }
}