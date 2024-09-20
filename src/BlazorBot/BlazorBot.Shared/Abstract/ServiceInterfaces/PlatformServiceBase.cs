using BlazorBot.Shared.Enums;
using BlazorBot.Shared.Models;

namespace BlazorBot.Shared.Abstract.ServiceInterfaces;

public abstract class PlatformServiceBase
{
    public event Func<Task>? OnConnectionClosed;
    public event Func<Task>? OnConnectionReconnecting;
    public event Func<Task>? OnConnectionReconnected;
    public event Func<Task>? OnConnectionConnected;
    public event Func<bool, Task>? OnAuthStateReceived;
    public event Func<ChatMessageDetail, Task>? OnChatReceived;
    public event Func<MessageType, string, Task>? OnMessageReceived;

    public abstract Task Connect();
    public abstract Task Disconnect();
    public abstract Task<string> GetBotResponse(string message);
}
