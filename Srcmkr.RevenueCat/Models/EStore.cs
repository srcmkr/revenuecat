using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Srcmkr.RevenueCat.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum EStore
{
    [EnumMember(Value = "app_store")]
    AppStore,
    
    [EnumMember(Value = "mac_app_store")]
    MacAppStore,
    
    [EnumMember(Value = "play_store")]
    PlayStore,
    
    [EnumMember(Value = "amazon")]
    Amazon,
    
    [EnumMember(Value = "stripe")]
    Stripe,
    
    [EnumMember(Value = "promotional")]
    Promotional
}