using BlazorBot.Shared.Abstract.ServiceInterfaces;

namespace BlazorBot.ServerServices.Services;

public class YouTubeBotService : PlatformServiceBase
{
    public override Task Connect()
    {
        throw new NotImplementedException();
    }

    public override Task Disconnect()
    {
        throw new NotImplementedException();
    }

    public override Task<string> GetBotResponse(string message)
    {
        throw new NotImplementedException();
    }
}