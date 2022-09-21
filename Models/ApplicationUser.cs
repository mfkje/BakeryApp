﻿using Microsoft.AspNetCore.Identity;

namespace BakeryApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
