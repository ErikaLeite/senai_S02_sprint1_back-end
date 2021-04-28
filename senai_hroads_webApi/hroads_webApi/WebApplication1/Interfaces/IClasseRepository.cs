using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();
        Classe BuscarPorId(int id);
        void Cadastrar(Classe novaClasse);
        void Atualizar(int id, Classe classeAtualizada);
        void Deletar(int id);
    }
}
