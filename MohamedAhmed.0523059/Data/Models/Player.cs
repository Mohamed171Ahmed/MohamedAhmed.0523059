using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MohamedAhmed._0523059.Data.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
    
        public string Postion { get; set; }
        public int Age { get; set; }

        public Team Team { get; set; }
        [ForeignKey(nameof(Team))]  
        public int TeamID { get; set; }

        public IEnumerable<Competition> Competitions { get; set; }
    }
}
