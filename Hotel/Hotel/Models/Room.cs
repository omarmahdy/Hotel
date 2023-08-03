using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        [Required]  
        public int Room_num { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [ForeignKey("guest")]
        public int G_ID{ get; set; }

        public Guest guest { get; set; }
    }
}
