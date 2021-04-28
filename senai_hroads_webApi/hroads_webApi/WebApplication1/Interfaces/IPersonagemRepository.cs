using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> Listar();
        Personagem BuscarPorId(int id);
        void Cadastrar(Personagem novoPersonagem);
        void Atualizar(int id, Personagem personagemAtualizado);
        void Deletar(int id);
    }
}
