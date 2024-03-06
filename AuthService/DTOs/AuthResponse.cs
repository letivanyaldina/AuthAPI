using System.Text.Json.Serialization;

namespace AuthService;

public class AuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken {get; set;}
}