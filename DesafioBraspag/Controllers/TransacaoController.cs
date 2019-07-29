using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioBraspag.Model;
using DesafioBraspag.Service;
using DesafioBraspag.Service.Interfaces;

namespace DesafioBraspag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {

        private readonly ICalculadora _calculadora;

        public TransacaoController(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Transacao transacao)
        {

            var Response = new { ValorLiquido = Math.Round(_calculadora.CalcularTaxa(transacao), 2) };

            return Ok(Response);
        }
    }
}