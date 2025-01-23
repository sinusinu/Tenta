using System.Text.Json.Serialization;

namespace Tenta;

public interface IOTPEntity {
    [JsonPropertyName("type")]
    public string Type { get; }

    [JsonPropertyName("name")]
    public string Name { get; }
    [JsonPropertyName("issuer")]
    public string Issuer { get; }

    [JsonPropertyName("secret")]
    public string Secret { get; }
    [JsonPropertyName("algorithm")]
    public string Algorithm { get; }
    [JsonPropertyName("digits")]
    public int Digits { get; }
    [JsonPropertyName("period")]
    public int Period { get; }
    
    [JsonIgnore]
    public string PrettyName { get; }

    public string GenerateCode();
    public string GeneratePrettifiedCode();
    public int GetTimeRemaining();
}