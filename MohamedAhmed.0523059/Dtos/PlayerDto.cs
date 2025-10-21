using System.ComponentModel.DataAnnotations;

namespace MohamedAhmed._0523059.Dtos
{
    public class PlayerDto
    {
        [Required]
        public string FullName { get; set; }

        public string Postion { get; set; }
        public int Age { get; set; }

    }
}
