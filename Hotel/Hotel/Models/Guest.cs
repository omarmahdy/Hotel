using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    [PrimaryKey(nameof(G_ID))]
    public class Guest
    {
        
        [Required] 
        public int G_ID { get; set; }
        [Required]
        [DisplayName("Phone number")]
        public string Phone_number { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("First name")]
        public string Fname { get; set; }
        [Required]
        [DisplayName("Last name")]
        public string Lname { get; set; }
        [Required]
        [DisplayName("Room number")]
        public int Room_num { get; set; }
        [Required]
        [DisplayName("Room Type")]
        public string Room_Type { get; set; }



        List<string> room_T = new List<string>()
            {
                "Single",
                "Double",
                "Suite"
            };
 

    }
  




}




