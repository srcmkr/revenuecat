![GitHub](https://img.shields.io/github/license/srcmkr/revenuecat) 
![Nuget](https://img.shields.io/nuget/v/Srcmkr.RevenueCat)
![Nuget](https://img.shields.io/nuget/dt/Srcmkr.RevenueCat)
[![Nuget CI/CD Pipeline](https://github.com/srcmkr/revenuecat/actions/workflows/publish-nuget.yml/badge.svg)](https://github.com/srcmkr/revenuecat/actions/workflows/publish-nuget.yml)

# RevenueCat C# SDK
Inofficial C# Revenuecat SDK for your Backend (WebAPI, ...)\
Nothing special (yet), but at least a navigatable response from the revenuecat API

## Installation
Install via Nuget (Srcmkr.RevenueCat) or CLI

```dotnet add package Srcmkr.RevenueCat```

## Usage
```
using Srcmkr.RevenueCat;

...

// Your secret API key
var client = RevenueCatClient.WithApiSecret("sk_XXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

// Any subscriber ID (auto-generated or alias)
var subscription = await client.GetSubscriber("$RCAnonymousID:71bae8c5044f4728a71c1781b5f59a87");

// Check if user has any subscriptions at all
var hasSubscription = subscription.Entitlements.ContainsKey("subscriptions");
if (!hasSubscription) 
{ 
    //handle no subscription 
}

// Check if user has any entitlement of the group "subscriptions" (<- change that)
// then checks if subscription is expired
var lastSubscription = subscription.Entitlements["subscriptions"];
if (lastSubscription.ExpiresDate < DateTime.UtcNow)
{
    return BadRequest(new ErrorResponse
    {
        Success = false,
        Message = "register.subscription_expired"
    });
}
 
```

## Roadmap

- [x] Get subscriber
- [ ] Native / preconfigured checkups
  - [ ] Expired subscription
  - [ ] Has specific (non-) subscription
- [ ] Delete Subscriber
- [ ] Add / Update User Attribution Data
- [ ] Entitlements
    - [ ] Grant a promotional entitlement
    - [ ] Revoke a promotional entitlement
- [ ] Support of API v2

See the [open issues](https://github.com/srcmkr/revenuecat/issuess) for a full list of proposed features (and known issues).

## License

Distributed under the MIT License. See `LICENSE` for more information.