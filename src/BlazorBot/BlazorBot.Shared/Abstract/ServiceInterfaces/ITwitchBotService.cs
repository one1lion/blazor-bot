using BlazorBot.Shared.Enums;
using BlazorBot.Shared.Models;

namespace BlazorBot.Shared.Abstract.ServiceInterfaces;
public interface ITwitchBotService
{
    event Func<Task>? OnHubConnectionClosed;
    event Func<Task>? OnHubConnectionReconnecting;
    event Func<Task>? OnHubConnectionReconnected;
    event Func<Task>? OnHubConnectionConnected;
    event Func<bool, Task>? OnAuthStateReceived;
    event Func<ChatMessageDetail, Task>? OnChatReceived;
    event Func<MessageType, string, Task>? OnMessageReceived;


}
