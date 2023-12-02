using BookShopMVC.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> GetBooks()
        {
            var books = await _dbContext.Books.ToListAsync();
            return Ok(books);
        }
    }
}
