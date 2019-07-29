using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBraspag.Model.Validation
{
    public class BandeiraValoresPermitidos : ValidationAttribute
    {

        public List<string> valoresPermitidos;


        public BandeiraValoresPermitidos()
        {
            valoresPermitidos = new List<string>()
            {
                "Visa", "Master"
            };
        }

        public override bool IsValid(object value)
        {
            string valorBandeira = (string) value;

            if(valoresPermitidos.Contains(valorBandeira))
            {
                return true;
            }

            return false;

        }



    }
}
