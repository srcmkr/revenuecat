# revenuecat
Inofficial C# Revenuecat SDK for your Backend (WebAPI, ...)
Nothing special (yet), but at least a navigatable response from the revenuecat API

### Usage
```
// Your secret API key
var client = RevenueCatClient.WithApiSecret("sk_XXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

// Any subscriber ID (auto-generated or alias)
var subscription = await client.GetSubscriber("$RCAnonymousID:71bae8c5044f4728a71c1781b5f59a87"); 
```
