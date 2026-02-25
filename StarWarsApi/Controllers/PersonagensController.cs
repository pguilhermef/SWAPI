using Microsoft.AspNetCore.Mvc;
using StarWarsApi.Services;

namespace StarWarsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonagensController: ControllerBase
{
    private readonly SwapiService _swapiService;

    public PersonagensController(SwapiService swapiService)
    {
        _swapiService = swapiService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> PegarPersonagemPorId(int id)
    {
        var personagem = await _swapiService.ObterPersonagemAsync(id);

        if (personagem == null)
            return NotFound();
        
        return Ok(personagem);
    }
}