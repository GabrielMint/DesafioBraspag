using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioBraspag.Repository;
using DesafioBraspag.Repository.Interfaces;
using DesafioBraspag.Service;

namespace DesafioBraspag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Aplicação desenvolvida por Gabriel Augusto para o Desafio da Braspag";
        }


    }
}