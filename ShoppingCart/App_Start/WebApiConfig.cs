using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShoppingCart.Models;

namespace ShoppingCart
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            MemoryRepository<Book>.Repo = new ConcurrentDictionary<int, Book>();
            MemoryRepository<Book>.Repo.TryAdd(1, new Book { Author = "Niklaus Wirth", Id = 1, Price = 100, Quantity = 10, Title = "Data structures" });
            MemoryRepository<Book>.Repo.TryAdd(2, new Book { Author = " Stephen g", Id = 2, Price = 200, Quantity = 100, Title = "Objective C" });
            MemoryRepository<Book>.Repo.TryAdd(3, new Book { Author = "Charles", Id = 3, Price = 300, Quantity = 1000, Title = "Logic desing" });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
