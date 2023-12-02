using BookShopMVC.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BookShopMVC.Controllers
{
    public class GetBooksController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GetBooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks()
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == 1);
            return Ok(book);
        }
    }
}
