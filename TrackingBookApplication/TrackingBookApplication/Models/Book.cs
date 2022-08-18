namespace TrackingBookApplication.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public string Author { get; set; }
        public List<Category> Categories { get; set; }

    }
}
