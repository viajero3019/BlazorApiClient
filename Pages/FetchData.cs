using System.Threading.Tasks;
using BlazorApiClient.Dtos;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorApiClient.Pages
{
    public partial class FetchData
    {
        [Inject]
        private HttpClient Http { get; set; }
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {
            // launches = await Http.GetFromJsonAsync<LaunchDto[]>("sample-data/launches.json");
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("sample-data/launches.json");
        }
    }
}