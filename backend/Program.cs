var client = new HttpClient();
client.BaseAddress = new Uri("https://swapi.dev/api/");

var request = await client.GetAsync("people/2");
var response = await request.Content.ReadAsStringAsync();

Console.WriteLine(response);