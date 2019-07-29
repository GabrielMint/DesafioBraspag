using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model;
using DesafioBraspag.Repository.Interfaces;

namespace DesafioBraspag.Repository
{
    public class MdrRepository : IMdrRepository
    {
        private List<MDR> listaMdr;

        private readonly ITaxaRepository _taxaRepository;

        public MdrRepository(ITaxaRepository taxaRepository)
        {
            _taxaRepository = taxaRepository;
        }

        public List<MDR> RetornarMDR()
        {
            return listaMdr = new List<MDR>()
            {
                new MDR()
                {
                    Adquirente = "Adquirente A",
                    Taxas = _taxaRepository.RetornarTaxasA()
                },
                new MDR()
                {
                    Adquirente = "Adquirente B",
                    Taxas = _taxaRepository.RetornarTaxasB()
                },
                new MDR()
                {
                    Adquirente = "Adquirente C",
                    Taxas = _taxaRepository.RetornarTaxasC()
                }
            };
        }

    }
}
