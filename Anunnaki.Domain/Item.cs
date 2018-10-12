using Anunnaki.Domain.Interfaces;
using System;

namespace Anunnaki.Domain.Entities
{
    ///Produto de uma compra
    public class Item : Produto, IEntity
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public int Quantidade { get; set; }

        public new bool isValid()
        {
            base.isValid();
            throw new NotImplementedException();
        }
    }
}