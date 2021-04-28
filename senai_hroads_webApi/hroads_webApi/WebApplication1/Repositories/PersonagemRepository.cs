using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadContext ctx = new HroadContext();
        public void Atualizar(int id, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = ctx.Personagems.Find(id);

            if (personagemAtualizado.NomePersonagem != null)
            {
                personagemBuscado.NomePersonagem = personagemAtualizado.NomePersonagem;
            }

            ctx.Personagems.Update(personagemBuscado);
            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int id)
        {
            return ctx.Personagems.FirstOrDefault(p => p.IdPersonagem == id);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagems.Add(novoPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Personagem personagemDeletado = ctx.Personagems.Find(id);

            ctx.Personagems.Remove(personagemDeletado);
            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}
