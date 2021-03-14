using CleanArchitecture.Aplicacao.Interfaces;
using CleanArchitecture.Aplicacao.ViewModels;
using CleanArchitecture.Dominio.Interfaces;

namespace CleanArchitecture.Aplicacao.Servicos
{
  public class ProdutoServico : IProdutoServico
  {
    public IProdutoRepositorio _produtoRepositorio;

    public ProdutoServico(IProdutoRepositorio produtoRepositorio)
    {
      _produtoRepositorio = produtoRepositorio;
    }

    public ProdutoViewModel ListarProdutos()
    {
      return new ProdutoViewModel
      {
        Produtos = _produtoRepositorio.ListarProdutos()
      };
    }
  }
}
