using Anunnaki.Domain.Interfaces;
using System;

public class Produto : IEntity
{
    public int IdProduto { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Criacao { get; set; }

    public bool isValid()
    {
        throw new NotImplementedException();
    }
}