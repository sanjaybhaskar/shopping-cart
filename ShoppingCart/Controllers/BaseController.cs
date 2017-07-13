﻿using System;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using ShoppingCart.Hubs;

namespace ShoppingCart.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected readonly Lazy<IHubContext> ShoppingCartHub = new Lazy<IHubContext>(() => GlobalHost.ConnectionManager.GetHubContext<ShoppingCartHub>());
        protected readonly Lazy<IHubContext> AdminHub = new Lazy<IHubContext>(() => GlobalHost.ConnectionManager.GetHubContext<AdminHub>());
    }
}