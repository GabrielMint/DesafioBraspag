using DesafioBraspag.Controllers;
using DesafioBraspag.Model;
using DesafioBraspag.Repository;
using DesafioBraspag.Repository.Interfaces;
using DesafioBraspag.Service;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesafioBraspag.Test
{
    public class CalculaTaxaTest
    {
        [Fact]
        public void Quando_Transacao_Valida_Deve_Retornar_Valor_Liquido()
        {
            var calculadora = new Calculadora(new MdrRepository(new TaxaRepository()));

            Transacao transacao = new Transacao()
            {
                Valor = 100,
                Adquirente = 'A',
                Bandeira = "Visa",
                Tipo = "Credito",
            };

            var valorEsperado = 97.75;

            var resultado = calculadora.CalcularTaxa(transacao);

            Assert.Equal(valorEsperado, resultado);

        }
    }
}
