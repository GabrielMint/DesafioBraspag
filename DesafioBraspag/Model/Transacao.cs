using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model.Validation;

namespace DesafioBraspag.Model
{
    public class Transacao
    {
        [Range(1, double.MaxValue)]
        [Required(ErrorMessage = "O Valor da Transação é obrigatório")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O Adquirente é obrigatório", AllowEmptyStrings = false)]
        [AdquirenteValoresPermitidos(ErrorMessage = "Adquirente Inválido!")]
        public char Adquirente { get; set; }

        [BandeiraValoresPermitidos(ErrorMessage = "Bandeira Inválida!")]
        [Required(ErrorMessage = "A bandeira é obrigatória", AllowEmptyStrings = false)]
        public string Bandeira { get; set; }

        [TipoTransacaoValoresPermitidos(ErrorMessage = "Tipo de Transacao Inválida!")]
        [Required(ErrorMessage = "O tipo de transação é obrigatório", AllowEmptyStrings = false)]
        public string Tipo { get; set; }
    }
}
