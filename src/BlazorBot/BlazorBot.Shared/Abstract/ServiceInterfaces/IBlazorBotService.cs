using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBot.Shared.Abstract.ServiceInterfaces;
public interface IBlazorBotService
{
    Task<string> GetBotResponse(string message);
    /*
     * For Semantic Kernel streaming
     * IAsyncEnumerable<ResponseDTO<ChatInputModel>> GenerateStreamingResponseAsync(ChatInputModel chatInputModel, CancellationToken cancellationToken = default);
     */
}
