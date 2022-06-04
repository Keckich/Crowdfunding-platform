namespace Сrowdfunding.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public int CommentId { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public Comment Comment { get; set; }
        public ApplicationUser User { get; set; }
    }
}
