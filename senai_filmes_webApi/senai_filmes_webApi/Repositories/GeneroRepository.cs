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
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdtateBody = "UPDATE Genero SET Nome = @Nome WHERE idGenero = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdtateBody, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", genero.nome);
                    cmd.Parameters.AddWithValue("@ID", genero.idGenero);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdtateUrl = "UPDATE Genero SET Nome = @Nome WHERE idGenero = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdtateUrl, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", genero.nome);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public GeneroDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idGenero, Nome FROM Genero WHERE idGenero = @ID";

                con.Open();

                SqlDataReader rdr;
                using(SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        GeneroDomain generoPesquisado = new GeneroDomain()
                        {
                            idGenero = Convert.ToInt32(rdr["idGenero"]),
                            nome     = rdr["Nome"].ToString()
                        };
                        return generoPesquisado;
                    }
                    return null;
                }
            }
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Genero(Nome) VALUES(@Nome)";
                using(SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    //passa o valor cadastrado para o @Nome
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.nome);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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
