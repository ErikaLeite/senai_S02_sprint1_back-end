using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class SituacoRepository : ISituacoRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Situaco situacoAtualizada)
        {
            throw new NotImplementedException();
        }

        public Situaco BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Situaco situacoNova)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Situaco> ListarTodos()
        {
            return ctx.Situacoes.ToList();
        }
    }
}
