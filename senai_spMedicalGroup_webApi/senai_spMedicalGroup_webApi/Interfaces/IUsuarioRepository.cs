using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(int id);
        void Cadastrar(Usuario usuarioNovo);
        void Atualizar(int id, Usuario usuarioAtualizado);
        void Deletar(int id);

        /// <summary>
        /// Método valida email e senha do user para autenticação de login
        /// </summary>
        /// <param name="email"> email do user cadastrado</param>
        /// <param name="senha">senha do user cadastrado</param>
        /// <returns></returns>
        Usuario Login(string email, string senha);
    }
}
