using Core.Models;
using Core.Models;
namespace Core.Interfaces;
public interface IPokemonRepository : IRepository<Pokemon>
{
    Task<Pokemon?> GetByNameAsync(string name);
    Task<IReadOnlyList<Pokemon>> SearchAsync(string searchTerm);
}
