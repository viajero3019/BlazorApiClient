using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApiClient.Dtos;

namespace BlazorApiClient.DataServices
{
    public class RESTSpaceXDataServices : ISpaceXDataServices
    {
        private readonly HttpClient _httpClient;

        public RESTSpaceXDataServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LaunchDto[]> GetAllLaunches()
        {
            return await _httpClient.GetFromJsonAsync<LaunchDto[]>("");
        }
    }
}