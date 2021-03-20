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

            
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                
                string querySelectAll = "SELECT idFilme, codGenero,Titulo FROM Filme";
                con.Open();
                
                SqlDataReader rdr;
                
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();
                                        
                    while (rdr.Read())
                    {                        
                        FilmeDomain filme = new FilmeDomain()
                        {
                            idFilme  = Convert.ToInt32(rdr[0]),
                            idGenero = Convert.ToInt32(rdr[1]),
                            titulo   = rdr[2].ToString()
                        };
                        
                        listaFilme.Add(filme);
                    }
                }
            }

            return listaFilme;
        }
    }
}
