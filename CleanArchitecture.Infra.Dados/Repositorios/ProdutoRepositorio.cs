using CleanArchitecture.Dominio.Interfaces;
using CleanArchitecture.Dominio.Modelos;
using CleanArchitecture.Infra.Dados.Contextos;
using System.Collections.Generic;

namespace CleanArchitecture.Infra.Dados.Repositorios
{
  public class ProdutoRepositorio : IProdutoRepositorio
  {
    public AplicacaoBDContexto _contexto;

    public ProdutoRepositorio(AplicacaoBDContexto contexto)
    {
      _contexto = contexto;
    }

    public IEnumerable<Produto> ListarProdutos()
    {
      return _contexto.Produtos;
    }
  }
}
