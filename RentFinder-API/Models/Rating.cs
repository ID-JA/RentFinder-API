using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class Rating
    {
        public string IdUser { get; set; }
        public Guid IdAnnouncement { get; set; }
        public int Value { get; set; }

        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }

        [ForeignKey("IdAnnouncement")]
        public Announcement Announcement { get; set; }
    }
}
