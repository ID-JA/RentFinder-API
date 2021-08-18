using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Picture { get; set; }

        public string City { get; set; }

        public ICollection<Announcement> Announcements { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Rating> Ratings { get; set; }

    }
}
