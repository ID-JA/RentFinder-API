using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class FeedBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdFeedBack { get; set; }
        public string Content { get; set; }
        public int Value { get; set; }
        public string IdUser { get; set; }

        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }
    }
}
