using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class TeamRepository : ITeamRepository
{
    private readonly AppDbContext _context;
    public TeamRepository(AppDbContext context) => _context = context;

    public async Task<Team?> GetByIdAsync(int id) => 
        await _context.Teams.FindAsync(id);

    public async Task<IReadOnlyList<Team>> GetAllAsync() => 
        await _context.Teams.ToListAsync();

    public async Task<IReadOnlyList<Team>> GetTeamsByUserAsync(string userId) => 
        await _context.Teams.ToListAsync(); // Implement user filtering later

    public async Task<Team> AddAsync(Team entity)
    {
        await _context.Teams.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(Team entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Team entity)
    {
        _context.Teams.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
