using senai_spMedicalGroup_webApi.Contexts;
using senai_spMedicalGroup_webApi.Domains;
using senai_spMedicalGroup_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, TiposUsuario tiposUAtualizado)
        {
            TiposUsuario tipoUBuscado = BuscarPorId(id);

            if (tiposUAtualizado.Titulo != null)
            {
                tipoUBuscado.Titulo = tiposUAtualizado.Titulo;
            }

            ctx.TiposUsuarios.Update(tipoUBuscado);
            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(tu => tu.IdTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuario tiposUsuarioNovo)
        {
            ctx.TiposUsuarios.Add(tiposUsuarioNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TiposUsuarios.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<TiposUsuario> ListarTodos()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
