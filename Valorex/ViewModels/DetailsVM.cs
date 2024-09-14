using Valorex.Models;

namespace Valorex.ViewModels;

public class DetailsVM
{
    public Personagem Anterior { get; set; }
    public Personagem Atual { get; set; }
    public Personagem Proximo { get; set; }
}