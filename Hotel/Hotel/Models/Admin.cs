using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Admin
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string username { get; set; } = "Mahdy";
        [Required]
        public string password { get; set; } = "Mahdy500";
    }
}
