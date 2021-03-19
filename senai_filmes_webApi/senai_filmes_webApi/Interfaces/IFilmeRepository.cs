using senai_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Interfaces
{
    public interface IFilmeRepository
    {
        //Nos retornará todos os generos listados
        List<FilmeDomain> ListarTodos();

        //Nos retornará apenas um genero pelo id informado no (parametro)
        FilmeDomain BuscarPorId(int id);

        //o método cadastrará um novo gênero, incluindo id e nome
        void Cadastrar(FilmeDomain novoFilme);

    }
}
