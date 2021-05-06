using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface ISituacoRepository
    {
        List<Situaco> ListarTodos();
        Situaco BuscarPorId(int id);
        void Cadastrar(Situaco situacoNova);
        void Atualizar(int id, Situaco situacoAtualizada);
        void Deletar(int id);
    }
}
