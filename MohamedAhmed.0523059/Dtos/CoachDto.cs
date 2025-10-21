using MohamedAhmed._0523059.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace MohamedAhmed._0523059.Dtos
{
    public class CreateCoachDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Specialization { get; set; }

        [Required]
        public int ExperrienceYears { get; set; }

        public string Teamm { get; set; }

        public int numofPlayers { get; set; }

    }

    public class teamDto
    {
        public string Name { get; set; }
    }

}
