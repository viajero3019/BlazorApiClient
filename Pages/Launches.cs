using System.Threading.Tasks;
using BlazorApiClient.DataServices;
using BlazorApiClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorApiClient.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataServices SpaceXDataServices { get; set; }
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDataServices.GetAllLaunches();
        }
    }
}