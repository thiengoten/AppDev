using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week5.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(20)]
        public string Isbn { get; set; } = null!;

        public int StoreId { get; set; }

        public Store Store { get; set; } = null!;

        //public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;

        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Display(Name = "Page Number")]
        public int PageNum { get; set; }

        [StringLength(50)]
        public string Author { get; set; } = null!;

        [StringLength(50)]
        public string Category { get; set; } = null!;

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Desciption { get; set; } = null!;
    }
}
