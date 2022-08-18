namespace BookTrackingApp.Models
{
    public class Category
    {
        public string NameToken { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
