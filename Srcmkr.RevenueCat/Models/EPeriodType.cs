using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Srcmkr.RevenueCat.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum EPeriodType
{
    [EnumMember(Value = "normal")]
    Normal,
    
    [EnumMember(Value = "trial")]
    Trial,
    
    [EnumMember(Value = "intro")]
    Intro
}