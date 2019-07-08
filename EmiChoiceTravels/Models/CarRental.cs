using EmiChoiceTravels.Ennum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmiChoiceTravels.Models
{
    public class CarRental
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CarRentalId { get; set; }
        public string CarName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateToBeReturned { get; set; }
        public CarStatus CarStatus { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}