using System;
using TaskOrder.Models;

namespace TaskOrder.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
      public IEnumerable<Categoria> Categorias {get;}  
    }
}
