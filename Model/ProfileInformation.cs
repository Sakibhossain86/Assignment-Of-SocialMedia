using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaPlatform.Model
{
    public class ProfileInformation
    {
        [Key]
        public int ProfileId { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set;}
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
