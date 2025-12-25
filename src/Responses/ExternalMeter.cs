using System.Text.Json.Serialization;

namespace Artemis.Plugins.Modules.HomeWizard.Responses;

public class ExternalMeter
{
    [JsonPropertyName("unique_id")]
    public string UniqueId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}