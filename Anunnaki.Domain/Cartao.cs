using Anunnaki.Domain.Interfaces;
using System;

public class Cartao : IEntity
{
    public int IdCartao { get; set; }

    public int IdCliente { get; set; }

    public string Numero { get; set; }

    public string Nome { get; set; }

    public string Cvv { get; set; }

    public string Bandeira { get; set; }

    public string Validade { get; set; }

    ///if null == unlimited
    public decimal? Limite { get; set; }

    public Cliente Cliente { get; set; }

    public bool isValid()
    {
        throw new NotImplementedException();
    }
}