using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();
        TipoHabilidade BuscarPorId(int id);
        void Cadastrar(TipoHabilidade novoTipoHabilidade);
        void Atualizar(int id, TipoHabilidade tipoHabilidadeAtualizado);
        void Deletar(int id);
    }
}
