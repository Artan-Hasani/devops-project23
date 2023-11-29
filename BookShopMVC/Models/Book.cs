using System.ComponentModel.DataAnnotations;

namespace BookShopMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
