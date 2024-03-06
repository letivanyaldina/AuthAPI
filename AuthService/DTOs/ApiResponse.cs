using System.Text.Json.Serialization;

namespace AuthService;

public class ApiResponse
{
    [JsonPropertyName("status")]
    public bool status {get; set;}

    [JsonPropertyName("error_code")]
    public string? ErrorCode {get; set;}

    [JsonPropertyName("error_message")]
    public string? ErrorMessage {get; set;}

    [JsonPropertyName("data")]
    public dynamic? Data {get; set;}
}