using System.Text.Json.Serialization;

namespace AuthService;

public class AuthRequest
{
    [JsonPropertyName("user_name")]
    public string? UserName {get; set;}

    [JsonPropertyName("password")]
    public string? Password {get; set;}
}