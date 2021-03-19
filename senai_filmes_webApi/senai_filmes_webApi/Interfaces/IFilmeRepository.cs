using senai_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Interfaces
{
    public interface IFilmeRepository
    {
        //Nos retornará todos os filmes listados
        List<FilmeDomain> ListarTodos();

        //Nos retornará apenas um filme pelo id informado no (parametro)
        FilmeDomain BuscarPorId(int id);

        //o método cadastrará um novo filme, incluindo id, titulo e o id do genero
        void Cadastrar(FilmeDomain novoFilme);

        //O método atualizará um filme existente utilizando o id no corpo da request
        void AtualizarIdCorpo(FilmeDomain filme);

        //O método atualizará um filme através da url (ex.: localhost:5000/filme/2 - sendo "2" o id informado na request)
        void AtualizarIdUrl(int id, FilmeDomain filme);

        //o método deletará o filme cujo id seja referenciado no paramentro (ex.: o filme id: 1 titulo: X, será deletado quando o id "1" for inserido no paramentro do método)
        void Deletar(int id);

    }
}
