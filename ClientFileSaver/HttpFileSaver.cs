using Entities;
using Interfaces;
using System.Text;
using System.Text.Json;

namespace ClientFileSaver
{
    public class HttpFileSaver : IActionService
    {
        private readonly HttpClient _httpClient;
        private string url = "https://localhost:7023/";

        public HttpFileSaver()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(url) };
        }

        public async Task ExcecuteAction(Kat kat)
        {
            try
            {
                var json = JsonSerializer.Serialize(kat);
                var content = new StringContent(json, Encoding.UTF8, "aplication/json");
                await _httpClient.PostAsync("api/FileSaver", content);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
