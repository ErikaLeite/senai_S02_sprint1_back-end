using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Medico medicoAtualizada)
        {
            Medico medicoBuscado = BuscarPorId(id);

            if (medicoAtualizada.Nome != null)
            {
                medicoBuscado.Nome = medicoAtualizada.Nome;
            }
            ctx.Medicos.Update(medicoBuscado);
            ctx.SaveChanges();
        }

        public Medico BuscarPorId(int id)
        {
            return ctx.Medicos.FirstOrDefault(m => m.IdMedico == id);
        }

        public void Cadastrar(Medico medicoNovo)
        {
            ctx.Medicos.Add(medicoNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}
