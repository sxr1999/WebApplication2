using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitMVC.DBContext;
using UnitMVC.Models;

namespace UnitMVC.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MyDbContext _context;

        public HomeController( MyDbContext context)
        {
           
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            Book book1 = new Book() { 
                Name = book.Name,
                Price = book.Price
            };

            await _context.books.AddAsync(book1);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}