using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models;

public class NonSubscription
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("purchase_date")]
    public DateTime PurchaseDate { get; set; }

    [JsonProperty("store")]
    public EStore Store { get; set; }

    [JsonProperty("is_sandbox")]
    public bool IsSandbox { get; set; }

    [JsonProperty("store_transaction_id")]
    public string StoreTransactionId { get; set; }
}
