using senai_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Interfaces
{
   /// <summary>
   /// Classe responsável pela implementação de regras de negócio, o que é necessário possuir no projeto
   /// neste caso, implementaremos o CRUD - base para criação do projeto
   /// </summary>
    public interface IGeneroRepository
    {
        //Nos retornará todos os generos listados
        List<GeneroDomain> ListarTodos();

        //Nos retornará apenas um genero pelo id informado no (parametro)
        GeneroDomain BuscarPorId(int id);

        //o método cadastrará um novo gênero, incluindo id e nome
        void Cadastrar(GeneroDomain novoGenero);
    }
}
