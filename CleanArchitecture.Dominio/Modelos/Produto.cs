using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Dominio.Modelos
{
  public class Produto
  {
    public int Id { get; set; }

    [MaxLength(60)]
    public string Nome { get; set; }

    [Column(TypeName = "decimal(9,2) default 0")]
    public decimal Preco { get; set; }

    [Column(TypeName = "decimal(9,3) default 0")]
    public decimal Quantidade { get; set; }
  }
}
