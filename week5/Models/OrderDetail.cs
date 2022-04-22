using System.ComponentModel.DataAnnotations;

namespace week5.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public string BookIsbn { get; set; } = null!;
        public Book Book { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be more than 0.")]
        public int Quantity { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }
    }
}
