﻿using System;
using System.Collections.Generic;

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
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public string UserId { get; set; }
        public List<Like> Likes { get; set; }
        public List<Dislike> Dislikes { get; set; }
        public ApplicationUser User { get; set; }
    }
}
