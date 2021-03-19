using senai_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Interfaces
{
   /// <summary>
   /// Classe responsável pela implementação de regras de negócio, o que é necessário possuir no projeto
   /// Neste caso, implementaremos o CRUD - base para criação do projeto
   /// </summary>
    public interface IGeneroRepository
    {
        //Nos retornará todos os generos listados
        List<GeneroDomain> ListarTodos();

        //Nos retornará apenas um genero pelo id informado no (parametro)
        GeneroDomain BuscarPorId(int id);

        //O método cadastrará um novo gênero, incluindo id e nome
        void Cadastrar(GeneroDomain novoGenero);

        //O método atualizará um genero existente utilizando o id no corpo da request
        void AtualizarIdCorpo(GeneroDomain genero);

        //O método atualizará um genero através da url (ex.: localhost:5000/genero/4 - sendo "4" o id informado na request)
        void AtualizarIdUrl(int id, GeneroDomain genero);

        //o método deletará o genero cujo id seja referenciado no paramentro (ex.: o genero id: 1 nome: X, será deletado quando o id "1" for inserido no paramentro do método)
        void Deletar(int id);


    }
}
