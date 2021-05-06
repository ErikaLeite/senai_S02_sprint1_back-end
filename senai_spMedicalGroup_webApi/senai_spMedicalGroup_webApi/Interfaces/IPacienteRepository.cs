using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IPacienteRepository
    {
        List<Paciente> ListarTodos();
        Paciente BuscarPorId(int id);
        void Cadastrar(Paciente pacienteNovo);
        void Atualizar(int id, Paciente pacienteAtualizado);
        void Deletar(int id);
    }
}
