using DesafioBraspag.Model;
using DesafioBraspag.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesafioBraspag.Test
{
    public class MdrTest
    {

        [Fact]
        public void Quando_Pedido_MdrRepository_Retorna_Todas_As_Mdrs()
        {

            var mdrRepository = new MdrRepository(new TaxaRepository());

            List<MDR> listaEsperada = new List<MDR>()
            {
                new MDR()
                {
                    Adquirente = "Adquirente A",
                    Taxas = new List<Taxa>()
                    {
                        new Taxa() { Bandeira = "Visa", Credito = 2.25, Debito = 2.00 },
                        new Taxa() { Bandeira = "Master", Credito = 2.35, Debito = 1.98 }
                    }
                },

                new MDR()
                {
                    Adquirente = "Adquirente B",
                    Taxas = new List<Taxa>()
                    {
                        new Taxa() { Bandeira = "Visa", Credito = 2.50, Debito = 2.08 },
                        new Taxa() { Bandeira = "Master", Credito = 2.65, Debito = 1.75 }
                    }
                },

                new MDR()
                {
                    Adquirente = "Adquirente C",
                    Taxas = new List<Taxa>()
                        {
                            new Taxa() { Bandeira = "Visa", Credito = 2.75, Debito = 2.16 },
                            new Taxa() { Bandeira = "Master", Credito = 3.10, Debito = 1.58 }
                        }
                }

            };

            Assert.Equal(listaEsperada[0].Adquirente, mdrRepository.RetornarMDR()[0].Adquirente);

        }

    }
}
