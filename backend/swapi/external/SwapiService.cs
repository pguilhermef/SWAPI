using System.Net.Http.Json;
using System.Text.Json;

namespace backend.swapi.external;
using backend.swapi.dtos;

class SwapiService{
  private readonly HttpClient _httpClient;

  public SwapiService(HttpClient httpClient)
  {
    _httpClient = httpClient;
    _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
  }

  public async Task<PersonagemDTO> ObterPersonagemAsync(int id)
  {
    var response = await _httpClient.GetAsync($"people/{id}");

    if (!response.IsSuccessStatusCode)
      return null;
    
    return await response.Content.ReadFromJsonAsync<PersonagemDTO>();
  }
}