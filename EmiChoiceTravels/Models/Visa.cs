using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmiChoiceTravels.Models
{
    public class Visa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string VisaId { get; set; }
        public string VisaName { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}