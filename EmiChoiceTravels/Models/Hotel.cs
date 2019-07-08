using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmiChoiceTravels.Models
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string HotelId { get; set; }
        public string HotelName { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}