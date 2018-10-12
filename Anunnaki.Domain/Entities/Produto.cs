using Anunnaki.Domain.Exceptions;
using Anunnaki.Domain.Interfaces;
using System;

namespace Anunnaki.Domain.Entities
{
    public class Produto : IEntity
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Criacao { get; set; }

        public bool isValid()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new DomainException("O Campo Descrição é obrigatório");
            throw new NotImplementedException();
        }
    }
}