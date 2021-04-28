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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
