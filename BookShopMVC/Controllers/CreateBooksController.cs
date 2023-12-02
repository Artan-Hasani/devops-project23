using BookShopMVC.Models;
using BookShopMVC.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShopMVC.Controllers
{
    public class CreateBooksController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public CreateBooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("CreateBooks")]
        public IActionResult CreateBooks()
        {
            var book = new Book() {Author = "Tom", ISBN = "12345", Title = "Moon", PublishedDate = new DateTime(2002,10,12).ToUniversalTime() };

            _dbContext.Books.Add(book);
            var result = _dbContext.SaveChanges();

            return Ok(result);
        }
    }
}
