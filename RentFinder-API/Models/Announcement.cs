using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class Announcement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Photos { get; set; }

        public string Title { get; set; }

        public float price { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int TotalFloors { get; set; }

        public int TotalBathrooms { get; set; }

        public int TotalLivingrooms { get; set; }

        public int TotalKitchens { get; set; }

        public int TotalBedrooms { get; set; }

        public float Surface { get; set; }

        public bool IsAvailable { get; set; }


        public string IdUser { get; set; }

        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Rating> Ratings { get; set; }

    }
}
