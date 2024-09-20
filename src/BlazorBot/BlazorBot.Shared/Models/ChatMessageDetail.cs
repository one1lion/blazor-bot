namespace BlazorBot.Shared.Models;

public class ChatMessageDetail
{
    public required string UserName { get; init; }
    public string? Message { get; set; }
}
