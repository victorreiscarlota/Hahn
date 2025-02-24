namespace Core.Models;
public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Pokemon> Pokemons { get; set; } = new();
}
