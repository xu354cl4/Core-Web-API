using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AjaxController : Controller
    {
        private readonly NorthwindContext _context;

        public AjaxController(NorthwindContext context)
        {
            _context = context;
        }
        //GET: Ajax/Greet
        [HttpGet]
        public string Greet(string Name)
        {
            Thread.Sleep(3000);
            return $"Hello, {Name}!";
        }
        //POST: Ajax/PostGreet
        [HttpPost]
        public string PostGreet(string Name)
        {
            Thread.Sleep(3000);
            return $"Hello, {Name}!";
        }
        //POST: Ajax/CheckName
        [HttpPost]
        public string CheckName(string FirstName)
        {
            bool Exists = _context.Customers.Any(e => e.ContactName == FirstName);
            return Exists ? "true" : "false";
        }
    }
}
