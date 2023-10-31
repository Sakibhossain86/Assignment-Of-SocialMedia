using System.ComponentModel.DataAnnotations;

namespace SocialMediaPlatform.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public ICollection<Post>? Posts { get; set; }
        //public ICollection<ProfileInformation>? Profiles { get; set; }

    }
}
