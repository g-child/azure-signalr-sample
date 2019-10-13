using Microsoft.AspNetCore.SignalR;

namespace SignalRServiceSample.Web.Models
{
    public class Chat : Hub
    {
        public void BroadCastMessage(string name, string message)
            => Clients.All.SendAsync("broadcastmessage", name, message);

        public void Echo(string name, string message)
            => Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
    }
}
