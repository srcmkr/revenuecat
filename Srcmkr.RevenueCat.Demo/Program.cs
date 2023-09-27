using Newtonsoft.Json;
using Srcmkr.RevenueCat;

Console.WriteLine("Hello, World!");

var client = RevenueCatClient.WithApiSecret("sk_XnpWnxrSigZHrrgpWFENolZuXKsKo");
var subscription = await client.GetSubscriber("08d82ff1-dd0c-48b9-8753-58d29cb59c49");

Console.WriteLine(JsonConvert.SerializeObject(subscription));