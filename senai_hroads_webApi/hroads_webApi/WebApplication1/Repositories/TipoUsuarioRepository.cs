using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class TipoUsuarioRepository: ITipoUsuarioRepository
    {
        HroadContext ctx = new HroadContext();

        public void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoBuscado = ctx.TipoUsuarios.Find(id);

            if (tipoUsuarioAtualizado.TipoUsuario1 != null)
            {
                tipoBuscado.TipoUsuario1 = tipoUsuarioAtualizado.TipoUsuario1;
            }

            ctx.TipoUsuarios.Update(tipoBuscado);
            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(novoTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario tipoDeletado = ctx.TipoUsuarios.Find(id);

            ctx.TipoUsuarios.Remove(tipoDeletado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
