using MohamedAhmed._0523059.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MohamedAhmed._0523059.Dtos
{
    public class TeamDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }

      
        public CoachDto CoachName { get; set; }
    }

    public class CoachDto
    {
        public string name { get; set; }
    }
}
