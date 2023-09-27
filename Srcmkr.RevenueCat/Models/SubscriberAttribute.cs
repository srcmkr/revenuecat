using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models;

public class SubscriberAttribute
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("updated_at_ms")]
    public long UpdatedAtMs { get; set; }
}
