using Anunnaki.Domain.Interfaces;
using System.Collections.Generic;

public class Compra : IEntity
{
    public int IdCompra { get; set; }
    public int IdCliente { get; set; }
    public int IdCartao { get; set; }
    public List<Item> Itens { get; set; }
    public Cliente Cliente { get; set; }
    public Cartao Cartao { get; set; }

    public bool isValid()
    {
        throw new System.NotImplementedException();
    }
}