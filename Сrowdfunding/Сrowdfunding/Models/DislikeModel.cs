using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class Dislike
    {
        public int DislikeId { get; set; }
        public int CommentId { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public Comment Comment { get; set; }
        public ApplicationUser User { get; set; }
    }
}
