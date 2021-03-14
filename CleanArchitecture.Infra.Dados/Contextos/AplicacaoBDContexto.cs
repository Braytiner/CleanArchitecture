using CleanArchitecture.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Dados.Contextos
{
  public class AplicacaoBDContexto : DbContext
  {
    public AplicacaoBDContexto(DbContextOptions opcoes) : base(opcoes)
    {

    }

    public DbSet<Produto> Produtos { get; set; }
  }
}
