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
            Situaco situacoBuscada = BuscarPorId(id);

            if (situacoAtualizada != null)
            {
                situacoBuscada.Titulo = situacoAtualizada.Titulo;
            }

            ctx.Situacoes.Update(situacoBuscada);
            ctx.SaveChanges();
        }

        public Situaco BuscarPorId(int id)
        {
            return ctx.Situacoes.FirstOrDefault(s => s.IdSituacao == id);
        }

        public void Cadastrar(Situaco situacoNova)
        {
            ctx.Situacoes.Add(situacoNova);

            ctx.SaveChanges();
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
