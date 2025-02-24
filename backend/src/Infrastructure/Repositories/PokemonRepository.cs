using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class PokemonRepository : IPokemonRepository
{
    private readonly AppDbContext _context;
    public PokemonRepository(AppDbContext context) => _context = context;

    public async Task<Pokemon?> GetByIdAsync(int id) => 
        await _context.Pokemons.FindAsync(id);

    public async Task<Pokemon?> GetByNameAsync(string name) => 
        await _context.Pokemons.FirstOrDefaultAsync(p => p.Name == name);

    public async Task<IReadOnlyList<Pokemon>> GetAllAsync() => 
        await _context.Pokemons.ToListAsync();

    public async Task<IReadOnlyList<Pokemon>> SearchAsync(string searchTerm) => 
        await _context.Pokemons
            .Where(p => p.Name != null && p.Name.Contains(searchTerm))
            .ToListAsync();

    public async Task<Pokemon> AddAsync(Pokemon entity)
    {
        await _context.Pokemons.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(Pokemon entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Pokemon entity)
    {
        _context.Pokemons.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
