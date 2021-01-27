using ProjetoFilmes.App.Entidades;
using System.Collections.Generic;

namespace ProjetoFilmes.App.Interface
{
    interface IAtorDAO
    {
        void Adicionar(Ator ator);

        void Atualizar(Ator ator);

        void Remover(Ator ator);

        IList<Ator> Atores();
        
    }
}
