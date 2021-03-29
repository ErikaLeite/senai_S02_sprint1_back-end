using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webApi.Domains;
using senai_filmes_webApi.Interfaces;
using senai_filmes_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Classe reponsável pelos EndPoints (URLs)
/// </summary>
namespace senai_filmes_webApi.Controllers
{
    //irá gerar a resposta no formato json
    [Produces("application/json")]

    //define a rota de uma request, http://localhost:5000/api/nomeController(Generos)    
    [Route("api/[controller]")]

    //define que é um controlador de APi
    [ApiController]
    public class GenerosController : ControllerBase
    {
        //Receberá os métodos implementados na interface, em outras palavras "saberá que há determinados métodos"
        private IGeneroRepository _generoRepository { get; set; }

        public GenerosController()
        {
            //instaciamos um novo objeto, mas dessa vez referenciando o _generoRepository (que vem de interfaces) com um novo objeto do repositório
            _generoRepository = new GeneroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            //criamos uma lista, onde o _gR irá armazenar os dados coletados do método ListarTodos
            List<GeneroDomain> listaGenero = _generoRepository.ListarTodos();

            //feito isso, retornamos as informações obtidas do IGeneroRepository com status com 200 (OK)
            return Ok(listaGenero);
        }

        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            _generoRepository.Cadastrar(novoGenero);

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _generoRepository.Deletar(id);

            return StatusCode(204);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            GeneroDomain generoPesquisado = _generoRepository.BuscarPorId(id);
            if (generoPesquisado == null)
            {
                return NotFound("Nenhhum gênero foi localizado.");
            }

            return Ok(generoPesquisado);
        }

        [HttpPut("{id}")]
        public IActionResult PutUrl (int id, GeneroDomain generoAtualizado)
        {
            GeneroDomain generoUrl = _generoRepository.BuscarPorId(id);

            _generoRepository.AtualizarIdUrl(id, generoAtualizado);

            if (generoUrl == null)
            {
                return NotFound
                    (new 
                    {
                        mensagem = "Gênero não localizado.",
                        erro     = true
                    }
                    );
            } 

            try
            {
                _generoRepository.AtualizarIdUrl(id, generoAtualizado);
                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }

        [HttpPut]
        public IActionResult PutBody (GeneroDomain generoAtualizado)
        {
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(generoAtualizado.idGenero);

            if (generoBuscado != null)
            {
                try
                {
                    _generoRepository.AtualizarIdCorpo(generoAtualizado);
                    return NoContent();
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                    
                }
            }

            return NotFound( new { mensagem = "Nenhum gênero localizado"} );
        }

    }
}
