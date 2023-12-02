using BookShopMVC.Models;
using BookShopMVC.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookShopMVC.Controllers
{
    public class CreateBookCommand
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishedDate { get; set; }
    }
    public class CreateBooksController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public CreateBooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("CreateBooks")]
        public IActionResult CreateBooks([FromBody] CreateBookCommand command)
        {
            var book = new Book() {Author = command.Author, ISBN = command.ISBN, Title = command.Title, PublishedDate = command.PublishedDate.ToUniversalTime() };

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
