using CleanArchitecture.Dominio.Modelos;
using System.Collections.Generic;

namespace CleanArchitecture.Dominio.Interfaces
{
  public interface IProdutoRepositorio
  {
    IEnumerable<Produto> ListarProdutos();
  }
}
