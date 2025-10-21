using System.ComponentModel.DataAnnotations;

namespace MohamedAhmed._0523059.Data.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<Team> Teams { get; set; }
        
    }
}
