using System.Collections.Generic;

public class Compra
{
    public int IdCompra { get; set; }
    public int IdCliente { get; set; }
    public int IdCartao { get; set; }
    public List<Item> Itens { get; set; }
    public Cliente Cliente { get; set; }
    public Cartao Cartao { get; set; }
}