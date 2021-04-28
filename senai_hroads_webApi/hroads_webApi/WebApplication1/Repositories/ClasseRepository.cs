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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
