using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ShoppingCart.Hubs
{
    [HubName("cart")]
    public class ShoppingCartHub : Hub
    {}
}