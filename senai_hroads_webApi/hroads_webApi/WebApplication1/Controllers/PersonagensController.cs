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
    public class PersonagensController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }


        public PersonagensController()
        {
            _personagemRepository = new PersonagemRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personagemRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_personagemRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Personagem novoPersonagem)
        {
            _personagemRepository.Cadastrar(novoPersonagem);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, Personagem personagemAtualizado)
        {
            _personagemRepository.Atualizar(id, personagemAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            _personagemRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
