using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface ITiposUsuarioRepository
    {
        List<TiposUsuario> ListarTodos();
        TiposUsuario BuscarPorId(int id);
        void Cadastrar(TiposUsuario tiposUsuarioNovo);
        void Atualizar(int id, TiposUsuario tiposUsuarioAtualizado);
        void Deletar(int id);
    }
}
