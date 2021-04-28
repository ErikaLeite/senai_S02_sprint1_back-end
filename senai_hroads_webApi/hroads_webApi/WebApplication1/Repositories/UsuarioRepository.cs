using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadContext ctx = new HroadContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            if (usuarioAtualizado.NomeUsuario != null)
            {
                usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;
            }

            ctx.Usuarios.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioDeletado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarioDeletado);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
