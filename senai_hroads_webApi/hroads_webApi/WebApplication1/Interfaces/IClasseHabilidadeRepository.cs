using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IClasseHabilidadeRepository
    {
        List<ClasseHabilidade> Listar();
        ClasseHabilidade BuscarPorId(int id);
        void Cadastrar(ClasseHabilidade novaClasseHabilidade);
        void Atualizar(int id, Classe classeHabilidadeAtualizada);
        void Deletar(int id);
    }
}
