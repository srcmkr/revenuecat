using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models.Internal;

internal class SubscriberResponse
{
    [JsonProperty("request_date")]
    public DateTime RequestDate { get; set; }

    [JsonProperty("request_date_ms")]
    public long RequestDateMs { get; set; }

    [JsonProperty("subscriber")]
    public Subscriber Subscriber { get; set; }
}