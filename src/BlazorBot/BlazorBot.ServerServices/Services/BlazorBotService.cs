using BlazorBot.Shared.Abstract.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBot.ServerServices.Services;
public class BlazorBotService : IBlazorBotService
{
    public Task<string> GetBotResponse(string message)
    {
        throw new NotImplementedException();
    }
}
