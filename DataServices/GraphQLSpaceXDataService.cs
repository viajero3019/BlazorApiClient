using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorApiClient.Dtos;

namespace BlazorApiClient.DataServices
{
    public class GraphQLSpaceXDataService : ISpaceXDataServices
    {
        private readonly HttpClient _httpClient;

        public GraphQLSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LaunchDto[]> GetAllLaunches()
        {
            var queryObject = new {
                query = @"{launches { id upcoming mission_name launch_date_local }}",
                variables = new {}
            };

            var launchQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                    Encoding.UTF8,
                    "application/json"
                );
            
            var response = await _httpClient.PostAsync("", launchQuery);

            if(response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GqlData>(await response.Content.ReadAsStreamAsync());
                return gqlData.Data.Launches;
            }
            return null;
        }
    }
}