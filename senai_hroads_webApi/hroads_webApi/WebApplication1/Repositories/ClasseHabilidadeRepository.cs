using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class ClasseHabilidadeRepository : IClasseHabilidadeRepository
    {
        HroadContext ctx = new HroadContext();
        public void Atualizar(int id, Classe classeHabilidadeAtualizada)
        {
            throw new NotImplementedException();
        }

        public ClasseHabilidade BuscarPorId(int id)
        {
            return ctx.ClasseHabilidades.FirstOrDefault(c => c.IdClasseHabilidade == id);
        }

        public void Cadastrar(ClasseHabilidade novaClasseHabilidade)
        {
            ctx.ClasseHabilidades.Add(novaClasseHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClasseHabilidade> Listar()
        {
            return ctx.ClasseHabilidades.ToList();
        }
    }
}
