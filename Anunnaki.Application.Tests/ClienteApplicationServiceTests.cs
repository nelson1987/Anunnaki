using NUnit.Framework;
using System;

namespace Anunnaki.Application.Tests
{
    //[TestCase]
    public class ClienteApplicationServiceTests
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
    }
}
