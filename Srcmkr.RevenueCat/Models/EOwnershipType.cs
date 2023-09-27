using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Srcmkr.RevenueCat.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum EOwnershipType
{
    [EnumMember(Value = "PURCHASED")]
    Purchased,

    [EnumMember(Value = "FAMILY_SHARED")]
    FamilyShared
}