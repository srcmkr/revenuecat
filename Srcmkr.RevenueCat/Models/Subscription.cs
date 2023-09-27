using Newtonsoft.Json;

namespace Srcmkr.RevenueCat.Models;

public class Subscription
{
    [JsonProperty("expires_date")]
    public DateTime? ExpiresDate { get; set; }

    [JsonProperty("purchase_date")]
    public DateTime PurchaseDate { get; set; }

    [JsonProperty("original_purchase_date")]
    public DateTime OriginalPurchaseDate { get; set; }

    [JsonProperty("ownership_type")]
    public EOwnershipType OwnershipType { get; set; }

    [JsonProperty("period_type")]
    public EPeriodType PeriodType { get; set; }

    [JsonProperty("store")]
    public EStore Store { get; set; }

    [JsonProperty("is_sandbox")]
    public bool IsSandbox { get; set; }

    [JsonProperty("unsubscribe_detected_at")]
    public DateTime? UnsubscribeDetectedAt { get; set; }

    [JsonProperty("billing_issues_detected_at")]
    public DateTime? BillingIssuesDetectedAt { get; set; }

    [JsonProperty("grace_period_expires_date")]
    public DateTime? GracePeriodExpiresDate { get; set; }

    [JsonProperty("refunded_at")]
    public DateTime? RefundedAt { get; set; }

    [JsonProperty("auto_resume_date")]
    public DateTime? AutoResumeDate { get; set; }

    [JsonProperty("store_transaction_id")]
    public string StoreTransactionId { get; set; }
}
