using BlazorBot.Shared.Abstract.ServiceInterfaces;

namespace BlazorBot.ServerServices.Services;

public class BlazorBotService : IBlazorBotService
{
    public Task<string> GetBotResponse(string message)
    {
        throw new NotImplementedException();
    }
}
