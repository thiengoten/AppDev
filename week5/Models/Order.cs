﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using week5.Areas.Identity.Data;

namespace week5.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
