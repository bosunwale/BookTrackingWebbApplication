using System.ComponentModel.DataAnnotations;

namespace BookTrackingApp.Models
{
    public class Book
    {
        //properties for the book class
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public string Author { get; set; }

    }
}
