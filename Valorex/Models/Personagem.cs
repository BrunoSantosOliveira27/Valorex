using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valorex.Models;

[Table("Personagem")]
public class Personagem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int Ano_Nascimento { get; set; }

    [StringLength(30)]
    public string Origem { get; set; }


    public int Categoria_id { get; set; }
    [ForeignKey("Categoria_id")]
    public Categoria Categoria { get; set; }

    [Required]
     public int Genero_id { get; set; }
    [ForeignKey("Genero_id")]
    public Genero Genero { get; set; }



}
