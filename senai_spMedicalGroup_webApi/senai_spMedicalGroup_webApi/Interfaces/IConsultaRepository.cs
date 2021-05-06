using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> ListarTodos();
        Consulta BuscarPorId(int id);
        void Cadastrar(Consulta consultaNova);
        void Atualizar(int id, Consulta consultaAtualizada);
        void Deletar(int id);

        /// <summary>
        /// Lista todas as consultas do user logado
        /// </summary>
        /// <param name="id">id do user logado</param>
        /// <returns></returns>
        List<Consulta> MinhasConsultas(int id);

        /// <summary>
        /// Atualiza a desccrição de uma consulta
        /// </summary>
        /// <param name="id"> id da consulta a ser atualizada</param>
        /// <param name="descricao">campo descrição a ser atualizado</param>
        void AtualizarDescricao(int id, string descricao);

        /// <summary>
        /// Atualiza status da consulta selecionada pelo id
        /// </summary>
        /// <param name="id"> consulta a ser alterada</param>
        /// <param name="idSituacao"> id da nova situacao da consulta</param>
        void AtualizarSituacao(int id, int idSituacao);
    }
}
