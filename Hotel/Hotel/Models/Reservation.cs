using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int R_ID { get; set; }
        [Required]
        [ForeignKey("guest")]
        public int G_ID { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public int Num_of_Rooms { get; set; }

        public Guest guest { get; set; }
    }
}
