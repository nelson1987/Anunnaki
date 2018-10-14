using Anunnaki.Domain.Entities;
using NUnit.Framework;
using System;

namespace Anunnaki.Domain.Tests
{
    //[TestCase]
    public class ClienteTests
    {
        [Test]
        private void CadastrarCliente()
        {
            var nomeCliente = "";
            var emailCliente = "";

            var cliente = new Cliente();
            cliente.Nome = nomeCliente;
            cliente.Email = emailCliente;
            cliente.isValid();
            Assert.AreEqual(true, cliente.isValid());
        }

        [Test]
        private void CadastrarCartao()
        {
            var numeroCartao = "";
            var nomeCartao = "";
            var bandeiraCartao = "";
            var validadeCartao = "";
            var cvvCartao = "";
            decimal? limiteCartao = null;

            var cartao = new Cartao();
            cartao.Nome = nomeCartao;
            cartao.Numero = numeroCartao;
            cartao.Validade = validadeCartao;
            cartao.Bandeira = bandeiraCartao;
            cartao.Limite = limiteCartao;
            cartao.Cvv = cvvCartao;
            Assert.AreEqual(true, cartao.isValid());
        }
    }
}
