using backend.swapi.external;

HttpClient httpClient = new HttpClient();
var personagemUm = new SwapiService(httpClient).ObterPersonagemAsync(1);

Console.WriteLine(personagemUm);