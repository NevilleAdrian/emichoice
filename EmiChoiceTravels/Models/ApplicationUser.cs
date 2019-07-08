using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmiChoiceTravels.Models
{
    public class ApplicationUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
}