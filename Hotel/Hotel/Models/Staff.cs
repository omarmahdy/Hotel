using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Staff
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
