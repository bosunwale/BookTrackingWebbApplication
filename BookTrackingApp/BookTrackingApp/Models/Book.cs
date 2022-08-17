using System.ComponentModel.DataAnnotations;

namespace BookTrackingApp.Models
{
    public class Book
    {
        //properties for the book class
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        //Constraint for rating
        [Range(1, 10, ErrorMessage = "Rating is between 1 and 10")]
        public int BookRating { get; set; }
    }
}
