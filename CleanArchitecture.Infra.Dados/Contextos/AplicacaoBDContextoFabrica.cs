using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Infra.Dados.Contextos
{
  public class AplicacaoBDContextoFabrica : IDesignTimeDbContextFactory<AplicacaoBDContexto>
  {
    /*
     * Vamos ter que criar o AplicacaoDbContexto em tempo de projeto para gerar as migrações. Para isso, 
     * implementamos a interface IDesignTimeDbContextFactory<TContext>, pois por convenção, se uma 
     * classe que implementa esta interface for encontrada no mesmo projeto que o DbContext ou no 
     * projeto de inicialização do aplicativo, as ferramentas contornam as outras maneiras de criar o 
     * DbContext e usam a fábrica em tempo de projeto no seu lugar.
     */

    public AplicacaoBDContexto CreateDbContext(string[] args)
    {
      IConfiguration configuration = new ConfigurationBuilder()
        .AddUserSecrets("3d6b4c3d-cbec-4ff6-a303-a8575892d9da")
        .Build();

      var optionsBuilder = new DbContextOptionsBuilder<AplicacaoBDContexto>();

      optionsBuilder.UseMySql(configuration.GetConnectionString("CleanArchitecture"));

      return new AplicacaoBDContexto(optionsBuilder.Options);
    }
  }
}
