using System;

namespace Anunnaki.Domain.Tests
{
    public class ClienteTests
    {
        private void CadastrarCliente()
        {
            var nomeCliente = "";
            var emailCliente = "";

            var cliente = new Cliente();
            cliente.Nome = nomeCliente;
            cliente.Email = emailCliente;
            cliente.isValid();
        }

        private void CadastrarCartao()
        {
            var numeroCartao = "";
            var nomeCartao = "";
            var bandeiraCartao = "";
            var validadeCartao = "";
            var cvvCartao = "";
            decimal? limiteCartao = null;

            var cliente = new Cartao();
            cliente.Nome = nomeCartao;
            cliente.Numero = numeroCartao;
            cliente.Validade = validadeCartao;
            cliente.Bandeira = bandeiraCartao;
            cliente.Limite = limiteCartao;
            cliente.Cvv = cvvCartao;
            cliente.isValid();
        }
    }
}
