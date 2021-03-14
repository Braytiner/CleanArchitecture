using CleanArchitecture.Aplicacao.Interfaces;
using CleanArchitecture.Aplicacao.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Mvc.Controllers
{
  public class ProdutosController : Controller
  {
    private IProdutoServico _produtoServico;

    public ProdutosController(IProdutoServico produtoServico)
    {
      _produtoServico = produtoServico;
    }

    public IActionResult Index()
    {
      ProdutoViewModel produtoViewModel = _produtoServico.ListarProdutos();
      return View(produtoViewModel);
    }
  }
}
