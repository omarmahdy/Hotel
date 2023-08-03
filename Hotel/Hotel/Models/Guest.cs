using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    [PrimaryKey(nameof(G_ID))]
    public class Guest
    {
        
        [Required] 
        public int G_ID { get; set; }
        [Required]
        public string Phone_number { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }       
    }
}
