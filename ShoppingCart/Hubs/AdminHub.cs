using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ShoppingCart.Hubs
{
    [HubName("admin")]
    public class AdminHub : Hub
    { }
}