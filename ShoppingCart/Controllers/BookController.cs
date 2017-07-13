using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class BookController : ApiController
    {
        private readonly IRepository<Book> _repository;

        public BookController() : this(new MemoryRepository<Book>())
        {
        }

        public BookController(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> Get()
        {
            return _repository.Items;
        }
    }
}