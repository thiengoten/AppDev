using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week5.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public AppUser User { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public double TotalPrice { get; set; }

        //public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
