using BlazorBot.Shared.Abstract.ServiceInterfaces;
using BlazorBot.Shared.Enums;
using BlazorBot.Shared.Models;

namespace BlazorBot.ServerServices.Services;
public class TwitchBotService : ITwitchBotService
{
    public event Func<Task>? OnHubConnectionClosed;
    public event Func<Task>? OnHubConnectionReconnecting;
    public event Func<Task>? OnHubConnectionReconnected;
    public event Func<Task>? OnHubConnectionConnected;
    public event Func<bool, Task>? OnAuthStateReceived;
    public event Func<ChatMessageDetail, Task>? OnChatReceived;
    public event Func<MessageType, string, Task>? OnMessageReceived;

    public Task<string> GetBotResponse(string message)
    {
        throw new NotImplementedException();
    }
}
