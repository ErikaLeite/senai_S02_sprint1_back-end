using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> ListarTodos();
        Especialidade BuscarPorId(int id);
        void Cadastrar(Especialidade especialidadeNova);
        void Atualizar(int id, Especialidade especialidadeAtualizada);
        void Deletar(int id);
    }
}
