using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> ListarTodos();
        Medico BuscarPorId(int id);
        void Cadastrar(Medico medicoNovo);
        void Atualizar(int id, Medico medicoAtualizada);
        void Deletar(int id);
    }
}
