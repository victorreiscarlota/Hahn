using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TeamsController : ControllerBase
{
    private readonly ITeamRepository _teamRepo;
    private readonly IPokemonRepository _pokemonRepo;

    public TeamsController(ITeamRepository teamRepo, IPokemonRepository pokemonRepo)
    {
        _teamRepo = teamRepo;
        _pokemonRepo = pokemonRepo;
    }

    [HttpPost]
    public async Task<ActionResult<Team>> CreateTeam(Team team)
    {
        var createdTeam = await _teamRepo.AddAsync(team);
        return CreatedAtAction(nameof(GetTeam), new { id = createdTeam.Id }, createdTeam);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Team>> GetTeam(int id)
    {
        var team = await _teamRepo.GetByIdAsync(id);
        return team != null ? Ok(team) : NotFound();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTeam(int id, Team team)
    {
        if (id != team.Id) return BadRequest();
        await _teamRepo.UpdateAsync(team);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTeam(int id)
    {
        var team = await _teamRepo.GetByIdAsync(id);
        if (team == null) return NotFound();
        await _teamRepo.DeleteAsync(team);
        return NoContent();
    }
}
