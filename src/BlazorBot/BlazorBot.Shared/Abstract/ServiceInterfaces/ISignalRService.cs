namespace BlazorBot.Shared.Abstract.ServiceInterfaces;
public interface ISignalRService
{
    
}

public interface ISignalRServerService
{

}

public interface ISignalRClientService
{
    event Func<Task>? OnHubConnectionClosed;
    event Func<Task>? OnHubConnectionReconnecting;
    event Func<Task>? OnHubConnectionReconnected;
    event Func<Task>? OnHubConnectionConnected;

    Task ConnectToHub();
    Task DisconnectFromHub();
}
