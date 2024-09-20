namespace BlazorBot.Shared.Abstract.BotModels;

public interface ICommand
{
    Task Execute();
    Task Execute(params ICommandParameter[] parms);
}

public interface ICommand<TRet>
{
    Task<TRet> Execute();
    Task<TRet> Execute(params ICommandParameter[] parms);
}

