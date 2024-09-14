using Valorex.Models;

namespace Valorex.ViewModels;

public class HomeVM
{
public List<Categoria> Categorias { get; set; }
public List<Personagem> Personagems { get; set; }
public List<Genero> Generos { get; set; }
public List<Habilidade> Habilidades { get; set; }
};