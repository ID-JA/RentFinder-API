using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class Favorite
    {
        public Guid UserId { get; set; }
        public Guid AnnouncementId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("AnnouncementId")]
        public Announcement Announcement { get; set; }
    }
}
