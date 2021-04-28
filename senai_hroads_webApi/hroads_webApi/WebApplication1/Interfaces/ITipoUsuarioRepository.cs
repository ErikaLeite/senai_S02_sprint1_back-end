using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();
        TipoUsuario BuscarPorId(int id);
        void Cadastrar(TipoUsuario novoTipoUsuario);
        void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado);
        void Deletar(int id);
    }
}
