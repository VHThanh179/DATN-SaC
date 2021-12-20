using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Hubs
{
    public class NotiHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            //Debug.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
    }
}
