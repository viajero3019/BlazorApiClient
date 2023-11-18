using System;
using System.Text.Json.Serialization;

namespace BlazorApiClient.Dtos
{
    public partial class LaunchDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("upcoming")]
        public bool Upcoming { get; set; }

        [JsonPropertyName("launch_date_local")]
        public DateTimeOffset LaunchDateLocal { get; set; }

        [JsonPropertyName("mission_name")]
        public string MissionName { get; set; }
    }
}