using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Especialidade especialidadeAtualizada)
        {
            Especialidade especialidadeBuscada = BuscarPorId(id);

            if (especialidadeAtualizada.Titulo != null)
            {
                especialidadeBuscada.Titulo = especialidadeAtualizada.Titulo;
            }

            ctx.Especialidades.Update(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public Especialidade BuscarPorId(int id)
        {
            return ctx.Especialidades.FirstOrDefault(e => e.IdEspecialidade == id);
        }

        public void Cadastrar(Especialidade especialidadeNova)
        {
            ctx.Especialidades.Add(especialidadeNova);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidades.ToList();
        }
    }
}
