using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        HroadContext ctx = new HroadContext();

        public void Atualizar(int id, TipoHabilidade tipoHabilidadeAtualizado)
        {
            TipoHabilidade tipoHabilidadeBuscado = ctx.TipoHabilidades.Find(id);

            if (tipoHabilidadeAtualizado.TipoHabilidade1 != null)
            {
                tipoHabilidadeBuscado.TipoHabilidade1 = tipoHabilidadeAtualizado.TipoHabilidade1;
            }

            ctx.TipoHabilidades.Update(tipoHabilidadeBuscado);
            ctx.SaveChanges();
        }

        public TipoHabilidade BuscarPorId(int id)
        {
            return ctx.TipoHabilidades.FirstOrDefault(t => t.IdTipoHabilidade == id);
        }

        public void Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            ctx.TipoHabilidades.Add(novoTipoHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoHabilidade tipoHDeletado = ctx.TipoHabilidades.Find(id);

            ctx.TipoHabilidades.Remove(tipoHDeletado);
            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
