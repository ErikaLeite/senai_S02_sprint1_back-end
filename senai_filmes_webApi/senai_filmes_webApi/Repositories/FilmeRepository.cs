using senai_filmes_webApi.Domains;
using senai_filmes_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string stringConexao = "Data Source = ERIKALEITE; initial catalog = Filme; user Id= sa; pwd=1801";
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public FilmeDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(FilmeDomain novoFilme)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> listaFilme = new List<FilmeDomain>();

            //Declaramos um objeto da biblioteca SQLConnection para utlizarmos a string de acesso ao BD, ao término da operação o using desconecta do servidor BD
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //string de comandos ao BD
                string querySelectAll = "SELECT idFilme, codGenero, Titulo FROM Filme";

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
                        FilmeDomain filme = new FilmeDomain()
                        {
                            idFilme  = Convert.ToInt32(rdr[0]),
                            idGenero = Convert.ToInt32(rdr[1]),
                            titulo   = rdr[2].ToString()
                        };
                        //Após a coleta dos dados, o método abaixo os adiciona à lista
                        listaFilme.Add(filme);
                    }
                }
            }

            return listaFilme;
        }
    }
}
