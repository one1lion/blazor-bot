namespace BlazorBot.Shared.Abstract.BotModels;

public interface ICommandParameter
{
    string Name { get; set; }
    string Value { get; set; }
}