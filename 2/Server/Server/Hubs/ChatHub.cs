using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace Server.Hubs
{
    public class ChatHub : Hub
    { 
        public async Task SendMessage(string message)
        {
            string msg = "[SignalR] [" + DateTime.Now.ToString() + "]: " + message;
            Console.WriteLine("SEND: " + msg);
            await Clients.All.SendAsync("ReceiveMessage", msg);
        }
    }
}
