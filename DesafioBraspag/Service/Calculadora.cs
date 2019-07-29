using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model;
using DesafioBraspag.Repository;
using DesafioBraspag.Repository.Interfaces;
using DesafioBraspag.Service.Interfaces;

namespace DesafioBraspag.Service
{
    public class Calculadora : ICalculadora
    {

        private readonly IMdrRepository _mdrRepository;

        public Calculadora(IMdrRepository mdrRepository)
        {
            _mdrRepository = mdrRepository;
        }

        public double CalcularTaxa(Transacao _transacao)
        {
            MDR Mdr = _mdrRepository.RetornarMDR().FirstOrDefault(mdr => mdr.Adquirente[mdr.Adquirente.Length - 1] == _transacao.Adquirente);

            Taxa taxa = Mdr.Taxas.FirstOrDefault(_taxa => _taxa.Bandeira == _transacao.Bandeira);

            if (_transacao.Tipo == "Credito") return CalcularTaxaCredito(_transacao, taxa);

            if (_transacao.Tipo == "Debito") return CalcularTaxaDebito(_transacao, taxa);

            return 0;
        }

        private double CalcularTaxaCredito(Transacao _transacao, Taxa taxa)
        {
            return _transacao.Valor - (_transacao.Valor * taxa.Credito / 100);
        }

        private double CalcularTaxaDebito(Transacao _transacao, Taxa taxa)
        {
            return _transacao.Valor - (_transacao.Valor * taxa.Debito / 100);
            
        }

       


    }
}
