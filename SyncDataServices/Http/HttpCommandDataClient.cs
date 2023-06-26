using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dotNET_Microservices.DTO;
using Microsoft.Extensions.Configuration;

namespace dotNET_Microservices.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommand(PlatformReadDto platformReadDto)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platformReadDto), Encoding.UTF8, "application/json");

            var response =
                await _httpClient.PostAsync($"{_configuration["CommandService"]}/api/c/platforms", httpContent);

            Console.WriteLine(response.IsSuccessStatusCode
                ? "---> Sync post to Command Service was ok"
                : "---> Sync post to Command Service was not ok");
        }
    }
}