using senai_spMedicalGroup_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_webApi.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> ListarTodos();
        Clinica BuscarPorId(int id);
        void Cadastrar(Clinica clinicaNova);
        void Atualizar(int id, Clinica clinicaAtualizada);
        void Deletar(int id);

    }
}
