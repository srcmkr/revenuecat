using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models;

public class Entitlement
{
    [JsonProperty("expires_date")]
    public DateTime? ExpiresDate { get; set; }

    [JsonProperty("grace_period_expires_date")]
    public DateTime? GracePeriodExpiresDate { get; set; }

    [JsonProperty("purchase_date")]
    public DateTime PurchaseDate { get; set; }

    [JsonProperty("product_identifier")]
    public string ProductIdentifier { get; set; }
}