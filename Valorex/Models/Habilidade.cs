
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valorex.Models;

[Table("Habilidade")]
public class Habilidade

{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int Personagem_id { get; set; }
    [ForeignKey("Personagem_id")]
    public Personagem Personagem { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }  
    
    public string Descricao { get; set; }


}
