using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBraspag.Model.Validation
{
    public class AdquirenteValoresPermitidos : ValidationAttribute
    {

        public List<char> valoresPermitidos;

        public AdquirenteValoresPermitidos()
        {
            valoresPermitidos = new List<char>()
            {
                'A', 'B', 'C'
            };
        }

        public override bool IsValid(object value)
        {
            char valorAdquirente = (char) value;

            if (valoresPermitidos.Contains(valorAdquirente))
            {
                return true;
            }

            return false;
        }


    }
}
