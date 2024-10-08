﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class Reward
    {
        public int RewardId { get; set; }
        public string Description { get; set; }
        public string Delivery { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public string ImageStorageName { get; set; }
    }
}
