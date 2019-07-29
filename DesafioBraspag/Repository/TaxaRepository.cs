using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model;
using DesafioBraspag.Repository.Interfaces;

namespace DesafioBraspag.Repository
{
    public class TaxaRepository : ITaxaRepository
    {

        private List<Taxa> TaxasA = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.25, Debito = 2.00 },
            new Taxa() { Bandeira = "Master", Credito = 2.35, Debito = 1.98 }
        };

        private List<Taxa> TaxasB = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.50, Debito = 2.08 },
            new Taxa() { Bandeira = "Master", Credito = 2.65, Debito = 1.75 }
        };

        private List<Taxa> TaxasC = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.75, Debito = 2.16 },
            new Taxa() { Bandeira = "Master", Credito = 3.10, Debito = 1.58 }
        };

  

        public List<Taxa> RetornarTaxasA()
        {
            return TaxasA;
        }

        public List<Taxa> RetornarTaxasB()
        {
            return TaxasB;
        }

        public List<Taxa> RetornarTaxasC()
        {
            return TaxasC;
        }



    }
}
