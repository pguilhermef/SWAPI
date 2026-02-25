using System.Text.Json;
using backend.swapi.external;

HttpClient httpClient = new HttpClient();
var personagemUm = new SwapiService(httpClient).ObterPersonagemAsync(3);

Console.WriteLine(JsonSerializer.Serialize(personagemUm));