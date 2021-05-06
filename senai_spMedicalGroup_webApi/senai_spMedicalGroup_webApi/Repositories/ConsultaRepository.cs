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
            Consulta consultaBuscada = BuscarPorId(id);

            if (consultaAtualizada.Descricao != null)
            {
                consultaBuscada.Descricao = consultaAtualizada.Descricao;
            }

            ctx.Consultas.Update(consultaBuscada);

            ctx.SaveChanges();
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
            return ctx.Consultas.FirstOrDefault(cn => cn.IdConsulta == id);
        }

        public void Cadastrar(Consulta consultaNova)
        {
            //Adiciona mais um objeto ao campo
            ctx.Consultas.Add(consultaNova);

            //salva as alterações no BD
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Consultas.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Consulta> ListarTodos()
        {
            return ctx.Consultas.ToList();
        }

        public List<Consulta> MinhasConsultas(int id)
        {
            throw new NotImplementedException();
        }
    }
}
