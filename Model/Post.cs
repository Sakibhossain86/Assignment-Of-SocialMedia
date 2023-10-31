using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaPlatform.Model
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } = null;
        public DateTime? PostDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }
}
