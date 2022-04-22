using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace week5.Models;

public class AppUser : IdentityUser
{
    public Store? Store { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = null!;

    [Display(Name = "Date of Birth")]
    public DateTime? DoB { get; set; }

    public string? Address { get; set; }
}

