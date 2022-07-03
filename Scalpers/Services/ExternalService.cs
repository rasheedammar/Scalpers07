using XCommas.Net;
using XCommas.Net.Objects;

namespace Scalpers.Services;

public class ExternalService
{
    private readonly XCommasApi _client;
    private const string apiKey = "54fa2ae3254a7e9fff4fafbd8729fc625e9e9ce7eb4babb53225aa2a1c56e4";
    private const string secret = "340480bd2d806cf23ebc3fc5c1c29e938d8354639bb7c5cfc6b5b4ef089ea81d67891669f0bb94411f89d42d7971ff43a2e6d1e81d275258153f3ad3546a201c4bef2ee42c5dc2abf693aac76f6104cda8cdc41e6376a76d1f2eea8b2e38a77e57c930fa";
    public ExternalService()
    {
        _client = new XCommasApi(apiKey, secret);
    }

    public async Task<XCommasResponse<Bot>> StartNewDealAsync(int botId)
    {
        var response = await _client.StartNewDealAsync(botId);
        return response;
    }
}
