using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesafioBraspag.Model;
using DesafioBraspag.Repository;
using DesafioBraspag.Repository.Interfaces;
using DesafioBraspag.Service;

namespace DesafioBraspag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MdrController : ControllerBase
    {

        public readonly IMdrRepository _mdrRepository;

        public MdrController(IMdrRepository mdrRepository)
        {
            _mdrRepository = mdrRepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mdrRepository.RetornarMDR());
        }

    }
}    

