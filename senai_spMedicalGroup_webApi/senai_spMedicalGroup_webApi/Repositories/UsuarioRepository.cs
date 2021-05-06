using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario userBuscado = BuscarPorId(id);

            if (usuarioAtualizado.Email != null)
            {
                userBuscado.Email = usuarioAtualizado.Email;
            }

            ctx.Usuarios.Update(userBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            ctx.Usuarios.Add(usuarioNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuarios.ToList();
        }





        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
