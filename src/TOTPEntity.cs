using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using OtpNet;

namespace Tenta;

public class TOTPEntity : IOTPEntity {
    private readonly string name;
    private readonly string issuer;
    private readonly string secret;
    private readonly string algorithm;
    private readonly int digits;
    private readonly int period;

    [JsonPropertyName("type")]
    public string Type => "totp";
    [JsonPropertyName("name")]
    public string Name => name;
    [JsonPropertyName("issuer")]
    public string Issuer => issuer;
    [JsonPropertyName("secret")]
    public string Secret => secret;
    [JsonPropertyName("algorithm")]
    public string Algorithm => algorithm;
    [JsonPropertyName("digits")]
    public int Digits => digits;
    [JsonPropertyName("period")]
    public int Period => period;
    
    [JsonIgnore]
    public string PrettyName => prettyName;
    
    private string prettyName;
    private Totp totp;

    public TOTPEntity(string name, string issuer, string secret, string algorithm, int digits = 6, int period = 30) {
        this.name = name;
        this.issuer = issuer;
        this.secret = secret;
        this.algorithm = algorithm;
        this.digits = digits;
        this.period = period;

        OtpHashMode algo;
        if (algorithm.ToLower() == "sha256") algo = OtpHashMode.Sha256;
        else if (algorithm.ToLower() == "sha512") algo = OtpHashMode.Sha512;
        else algo = OtpHashMode.Sha1;

        if (issuer.Length == 0 && name.Length == 0) prettyName = "Unknown";             // issuer and name are both empty (is this possible?)
        else if (issuer.Length == 0) prettyName = name;                                 // issuer is empty
        else if (name.Length == 0) prettyName = issuer;                                 // name is empty (pretty sure that this is required though...)
        else if (issuer != name && name.Length > 0) prettyName = $"{issuer} ({name})";  // both are not empty and different
        else prettyName = issuer;                                                       // both are not empty and same

        totp = new Totp(Base32Encoding.ToBytes(secret), period, algo, digits);
    }

    public static TOTPEntity? FromJSON(string data) {
        TOTPEntity? result = null;
        try {
            result = JsonSerializer.Deserialize<TOTPEntity>(data);
        } catch (JsonException) { return null; }
        return result;
    }

    public string GenerateCode() {
        return totp.ComputeTotp();
    }

    public string GeneratePrettifiedCode() {
        var rawCode = totp.ComputeTotp();
        var sb = new StringBuilder();
        int i = 0;
        foreach (char c in rawCode) {
            sb.Append(c);
            i++; if (i == 3) { sb.Append(' '); i = 0; }
        }
        return sb.ToString().Trim();
    }

    public int GetTimeRemaining() {
        return totp.RemainingSeconds();
    }
}