﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using week5.Models;

namespace week5.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    public DateTime? DoB { get; set; }
    public string? Address { get; set; }
    public Store? Store { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }

}

