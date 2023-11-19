using System.Threading.Tasks;
using BlazorApiClient.Dtos;

namespace BlazorApiClient.DataServices
{
    public interface ISpaceXDataServices
    {
        Task<LaunchDto[]> GetAllLaunches(); 
    }
}