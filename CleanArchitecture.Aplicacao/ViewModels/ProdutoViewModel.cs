using CleanArchitecture.Dominio.Modelos;
using System.Collections.Generic;

namespace CleanArchitecture.Aplicacao.ViewModels
{
  public class ProdutoViewModel
  {
    public IEnumerable<Produto> Produtos { get; set; }
  }
}
