using Core.Models;
using Core.Models;
namespace Core.Interfaces;
public interface ITeamRepository : IRepository<Team>
{
    Task<IReadOnlyList<Team>> GetTeamsByUserAsync(string userId);
}
