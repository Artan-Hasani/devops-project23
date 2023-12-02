using BookShopMVC.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BookShopMVC.Controllers
{
    public class GetBookByIDController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GetBookByIDController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetBookByID")]
        public IActionResult GetBookByID([FromQuery] int Id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == Id);
            return Ok(book);
        }
    }
}
