using ProjetoFilmes.App.Entidades;
using System.Collections.Generic;

namespace ProjetoFilmes.App.Interface
{
    interface IDAO<T>
    {
        void Adicionar(T item);

        void Atualizar(T item);

        void Remover(T item);

        IList<T> ListarTodos();
        
    }
}
