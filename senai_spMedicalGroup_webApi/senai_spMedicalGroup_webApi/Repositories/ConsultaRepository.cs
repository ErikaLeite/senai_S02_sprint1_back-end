using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Consulta consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarDescricao(int id, string descricao)
        {
            throw new NotImplementedException();
        }

        public void AtualizarSituacao(int id, int idSituacao)
        {
            throw new NotImplementedException();
        }

        public Consulta BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consulta consultaNova)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Consulta> MinhasConsultas(int id)
        {
            return ctx.Consultas.ToList();
        }
    }
}
