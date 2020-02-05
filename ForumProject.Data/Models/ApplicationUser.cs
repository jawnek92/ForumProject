using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ForumProject.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    { 
        public string profileImageUrl { get; set; }
        public int rating { get; set; }
        public DateTime memberSince { get; set; }
        public bool isActive { get; set; }
    }
}
