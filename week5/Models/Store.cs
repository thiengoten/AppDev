namespace week5.Models
{
    public class Store
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Slogan { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = null!;
    }
}
