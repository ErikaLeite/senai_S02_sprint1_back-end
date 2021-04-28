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
    public class TipoHabilidadesController : ControllerBase
    {
        private ITipoHabilidadeRepository _tipoHabilidadeRepository { get; set; }


        public TipoHabilidadesController()
        {
            _tipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoHabilidadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tipoHabilidadeRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(TipoHabilidade novoTipoH)
        {
            _tipoHabilidadeRepository.Cadastrar(novoTipoH);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, TipoHabilidade tipoHabilidadeAtualizada)
        {
            _tipoHabilidadeRepository.Atualizar(id, tipoHabilidadeAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            _tipoHabilidadeRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
