using Newtonsoft.Json;
using Srcmkr.RevenueCat.Models;
using Srcmkr.RevenueCat.Models.Internal;

namespace Srcmkr.RevenueCat;

public class RevenueCatClient
{
    private const string BaseUrlVersion1 = "https://api.revenuecat.com/v1/";
    private readonly HttpClient _httpClient;

    private RevenueCatClient(string apiKey)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(BaseUrlVersion1);
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
    }

    public static RevenueCatClient WithApiSecret(string apiKey)
    {
        return new RevenueCatClient(apiKey);
    }

    public async Task<Subscriber> GetSubscriber(string userAppId)
    {
        var responseStr = await _httpClient.GetStringAsync($"subscribers/{userAppId}");
        var response = JsonConvert.DeserializeObject<SubscriberResponse>(responseStr);
        if (response == null) throw new Exception("Subscription not found");
        return response.Subscriber;
    }
}