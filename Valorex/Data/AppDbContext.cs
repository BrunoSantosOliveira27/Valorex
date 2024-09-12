using Microsoft.EntityFrameworkCore;
using Valorex.Models;

namespace Valorex.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Habilidade> Habilidades { get; set; }
    public DbSet<Personagem> Personagems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}