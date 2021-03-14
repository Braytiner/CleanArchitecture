using CleanArchitecture.Aplicacao.Interfaces;
using CleanArchitecture.Aplicacao.Servicos;
using CleanArchitecture.Dominio.Interfaces;
using CleanArchitecture.Infra.Dados.Contextos;
using CleanArchitecture.Infra.Dados.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC.Extensoes
{
  public static class ServiceCollectionExtensao
  {
    public static IServiceCollection ConfigurarPersistencia(this IServiceCollection colecaoServicos, 
      IConfiguration configuracao)
    {
      colecaoServicos.AddDbContext<AplicacaoBDContexto>(opcoes =>
      {
        opcoes.UseMySql(configuracao.GetConnectionString("CleanArchitecture"));
      });

      colecaoServicos.AddScoped<IProdutoServico, ProdutoServico>();
      colecaoServicos.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

      return colecaoServicos;
    }
  }
}
