using System.Collections.Generic;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<Cartao> Cartoes { get; set; }
    public List<Compra> Compras { get; set; }
}