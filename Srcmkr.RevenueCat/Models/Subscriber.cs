using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models;

public class Subscriber
{
    [JsonProperty("original_app_user_id")]
    public string OriginalAppUserId { get; set; }

    [JsonProperty("original_application_version")]
    public string OriginalApplicationVersion { get; set; }

    [JsonProperty("original_purchase_date")]
    public DateTime? OriginalPurchaseDate { get; set; }

    [JsonProperty("management_url")]
    public string ManagementUrl { get; set; }

    [JsonProperty("first_seen")]
    public DateTime FirstSeen { get; set; }

    [JsonProperty("last_seen")]
    public DateTime LastSeen { get; set; }

    [JsonProperty("entitlements")]
    public Dictionary<string, Entitlement> Entitlements { get; set; }
    
    [JsonProperty("subscriptions")]
    public Dictionary<string, Subscription> Subscriptions { get; set; }

    [JsonProperty("non_subscriptions")]
    public Dictionary<string, List<NonSubscription>> NonSubscriptions { get; set; }

    [JsonProperty("subscriber_attributes")]
    public Dictionary<string, SubscriberAttribute> SubscriberAttributes { get; set; }
}