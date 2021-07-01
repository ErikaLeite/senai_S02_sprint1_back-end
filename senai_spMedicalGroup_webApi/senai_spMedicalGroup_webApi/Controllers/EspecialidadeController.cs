using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using senai_spMedicalGroup_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Controllers
{
    //define a categoria de resposta da api, no caso, JSON
    [Produces("application/json")]

    //rota da requisição url/api/nomeController
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository { get; set; }

        //instanciamos o obj a ser referenciado entre interface e repositories
        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_especialidadeRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_especialidadeRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post (Especialidade novaEspecialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(novaEspecialidade);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut ("{id}")]
        public IActionResult Put(int id, Especialidade especialidadeAtualizada)
        {
            try
            {
                _especialidadeRepository.Atualizar(id, especialidadeAtualizada);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
