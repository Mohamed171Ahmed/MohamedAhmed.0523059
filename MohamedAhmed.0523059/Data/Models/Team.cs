using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MohamedAhmed._0523059.Data.Models
{
    [Index(nameof(Name),IsUnique = true)]
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }

        public Coach Coach { get; set; }
        [ForeignKey(nameof(Coach))]
        public int CoachID { get; set; }

        public IEnumerable<Player> Players { get; set; }

        public IEnumerable<Competition> Competitions { get; set; } 
     

    }
}
