using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext() {} 
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Pokemon> Pokemons => Set<Pokemon>();
    public DbSet<Team> Teams => Set<Team>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>()
            .HasMany(t => t.Pokemons)
            .WithMany(p => p.Teams)
            .UsingEntity(j => j.ToTable("TeamPokemon"));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=PokemonTeamBuilder;User Id=sa;Password=Laranbanas02.;TrustServerCertificate=true");
}
