using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
  static async Task Main()
  {
    using var httpClient = new HttpClient();

    var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");

    var content = await response.Content.ReadAsStringAsync();

    Console.WriteLine(content);
  }
}
