using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBraspag.Model.Validation
{
    public class TipoTransacaoValoresPermitidos : ValidationAttribute
    {
        public List<string> valoresPermitidos;


        public TipoTransacaoValoresPermitidos()
        {
            valoresPermitidos = new List<string>()
            {
                "Credito", "Debito"
            };
        }

        public override bool IsValid(object value)
        {
            string valorBandeira = (string)value;

            if (valoresPermitidos.Contains(valorBandeira))
            {
                return true;
            }

            return false;

        }
    }
}
