using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;
using WebApplication1.Interfaces;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseHabilidadesController : ControllerBase
    {
        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }


        public ClasseHabilidadesController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_classeHabilidadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_classeHabilidadeRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(ClasseHabilidade novaClasseH)
        {
            _classeHabilidadeRepository.Cadastrar(novaClasseH);

            return StatusCode(201);
        }
    }
}
