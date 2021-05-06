using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        /// <summary>
        /// Objeto responsável pela conexão com o BD em todas as classes e métodos
        /// </summary>
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();

        public void Atualizar(int id, Clinica clinicaAtualizada)
        {
            Clinica clinicaBuscada = BuscarPorId(id);

            if(clinicaAtualizada.Nome != null)
            {
                clinicaBuscada.Nome = clinicaAtualizada.Nome;
            }

            ctx.Clinicas.Update(clinicaBuscada);

            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(int id)
        {
            return ctx.Clinicas.FirstOrDefault(c => c.IdClinica == id);
        }

        public void Cadastrar(Clinica clinicaNova)
        {
            ctx.Clinicas.Add(clinicaNova);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();

        }
    }
}
