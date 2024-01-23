using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    class ProductController : Controller
    {
        // Dependency Injection Pattern
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context=context;
        }
        //

        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int id){
            Product product = _context.Products.First(product => product.ProductId.Equals(id));
            return View(product);
        }
    }
}