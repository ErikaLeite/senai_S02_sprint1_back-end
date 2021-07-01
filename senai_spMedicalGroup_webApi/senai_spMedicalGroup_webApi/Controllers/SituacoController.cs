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
    public class SituacoController : ControllerBase
    {
        private ISituacoRepository _situacoRepository { get; set; }

        //instanciamos o obj a ser referenciado entre interface e repositories
        public SituacoController()
        {
            _situacoRepository = new SituacoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_situacoRepository.ListarTodos());
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
                return Ok(_situacoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]    
        [HttpPost]
        public IActionResult Post(Situaco novaSituaco)
        {
            try
            {
                _situacoRepository.Cadastrar(novaSituaco);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Situaco situacaoAtualizada)
        {
            try
            {
                _situacoRepository.Atualizar(id, situacaoAtualizada);

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
                _situacoRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}
