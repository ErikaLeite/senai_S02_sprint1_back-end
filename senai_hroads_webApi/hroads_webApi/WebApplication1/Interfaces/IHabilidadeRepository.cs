using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();
        Habilidade BuscarPorId(int id);
        void Cadastrar(Habilidade novaHabilidade);
        void Atualizar(int id, Habilidade habilidadeAtualizada);
        void Deletar(int id);
        
    }
}
