using Microsoft.AspNetCore.Mvc;

namespace BookShopMVC.Controllers
{
    public class CreateBooksController : Controller
    {
        [HttpPost("CreateBooks")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
