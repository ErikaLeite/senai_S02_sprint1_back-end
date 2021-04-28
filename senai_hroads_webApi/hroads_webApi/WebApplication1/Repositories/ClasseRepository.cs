using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadContext ctx = new HroadContext();
        public void Atualizar(int id, Classe classeAtualizada)
        {
            Classe classeBuscada = ctx.Classes.Find(id);

            if (classeAtualizada.NomeClasse != null)
            {
                classeBuscada.NomeClasse = classeAtualizada.NomeClasse;
            }
            ctx.Classes.Update(classeBuscada);
            ctx.SaveChanges();
        }
        public Classe BuscarPorId(int id)
        {
            return ctx.Classes.FirstOrDefault(c => c.IdClasse == id);
        }

        public void Cadastrar(Classe novaClasse)
        {
            ctx.Classes.Add(novaClasse);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Classe classeDeletada = ctx.Classes.Find(id);

            ctx.Classes.Remove(classeDeletada);
            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
