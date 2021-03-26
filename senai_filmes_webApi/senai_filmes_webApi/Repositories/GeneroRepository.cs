using senai_filmes_webApi.Domains;
using senai_filmes_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Repositories
{
    //Classe responsável pelo repositório dos Generos
    public class GeneroRepository : IGeneroRepository
    {
        //String responsável por realizar a conexão com o BD
        //                             "Nome do Servidor          Nome do Banco de Dados  Informações de login do Servidor";
        private string stringConexao = "Data Source = ERIKALEITE; initial catalog = Filme; user Id= sa; pwd=1801";
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Genero(Nome) VALUES('"+novoGenero.nome+"')";
                using(SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {
            List<GeneroDomain> listaGenero = new List<GeneroDomain>();

            //Declaramos um objeto da biblioteca SQLConnection para utlizarmos a string de acesso ao BD, ao término da operação o using desconecta do servidor BD
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //string de comandos ao BD
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";

                con.Open();

                //Criamos um leitor de dados para que haja retorno de informações do BD para o Back-End
                SqlDataReader rdr;

                // À partir deste ponto, iremos fazer comandos dentro do BD
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //o cmd irá armazenar em rdr as informações dos parametros da conexao
                    rdr = cmd.ExecuteReader();

                    //Enquanto houverem registros no banco, o laço irá se repetir
                    while (rdr.Read())
                    {
                        //O novo objeto irá coletar as propriedades do Domain (posição 0 - ID / posição 1 - Nome)
                        GeneroDomain genero = new GeneroDomain()
                        {
                            idGenero = Convert.ToInt32(rdr[0]),
                            nome     = rdr[1].ToString()
                        };
                        //Após a coleta dos dados, o método abaixo os adiciona à lista
                        listaGenero.Add(genero);
                    }
                }
            }

            return listaGenero;
        }
    }
}
