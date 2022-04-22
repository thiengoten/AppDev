﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using week5.Areas.Identity.Data;

namespace week5.Models
{
    public class Store
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Slogan { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<Book>? Books { get; set; }

    }
}
