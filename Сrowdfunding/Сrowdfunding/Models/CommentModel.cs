using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }
        public string Author { get; set; }
        public DateTime PostDate { get; set; }
    }
}
