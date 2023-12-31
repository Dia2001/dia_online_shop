﻿
namespace OnlineShop.Hubs
{
    /// <summary>
    /// This interface will define everything that exists on the signalR hub so the hub can be strongly typed.
    /// It will be inherited from by the signalR client that can also react to hub events so that the client is aware of what is available on the hub
    /// </summary>
    public interface IHubClient
    {
        Task SendSystemNotification();
        //Task BroadcastSystemNotification();
        //Task NewBroadcastMessage(string broadcastMessage, string secondMessage);
        //Task BroadcastMessage();
        Task ChatMessage();
    }
}
