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
    try
    {
      var response = await _httpClient.GetAsync($"people/{id}");

      if (!response.IsSuccessStatusCode)
      {
        return null;
      }

      var json = await response.Content.ReadAsStringAsync();

      var options = new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      };

      return JsonSerializer.Deserialize<PersonagemDTO>(json, options);
    }
    catch
    {
      return null;
    }
  }
}