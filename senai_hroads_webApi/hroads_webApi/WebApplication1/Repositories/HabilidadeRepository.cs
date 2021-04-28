using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadContext ctx = new HroadContext();
        public void Atualizar(int id, Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);

            if (habilidadeAtualizada.NomeHabilidade != null)
            {
                habilidadeBuscada.NomeHabilidade = habilidadeAtualizada.NomeHabilidade;
            }
            ctx.Habilidades.Update(habilidadeBuscada);
            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int id)
        {
            return ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Habilidade habilidadeDeletada = ctx.Habilidades.Find(id);

            ctx.Habilidades.Remove(habilidadeDeletada);
            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
