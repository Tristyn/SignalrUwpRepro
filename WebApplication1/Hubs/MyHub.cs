using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Hubs
{
    public class MyHub : Hub<IMyHubClient>
    {
    }

    public interface IMyHubClient
    {

    }
}
