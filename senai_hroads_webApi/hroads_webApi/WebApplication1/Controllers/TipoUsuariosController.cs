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
    public class TipoUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }


        public TipoUsuariosController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tipoUsuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(TipoUsuario novoTipo)
        {
            _tipoUsuarioRepository.Cadastrar(novoTipo);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, TipoUsuario tipoUsuarioAtualizado)
        {
            _tipoUsuarioRepository.Atualizar(id, tipoUsuarioAtualizado);

            return StatusCode(204);
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete (int id)
        {
            _tipoUsuarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
