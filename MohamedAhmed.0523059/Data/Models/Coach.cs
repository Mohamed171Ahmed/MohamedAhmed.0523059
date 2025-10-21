using System.ComponentModel.DataAnnotations;

namespace MohamedAhmed._0523059.Data.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Specialization { get; set; }

        [Required]
        public int ExperrienceYears { get; set; }

        public Team team { get; set; }
            

    }
}
