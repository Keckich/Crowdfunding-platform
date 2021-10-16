using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int TotalSum { get; set; }
        public int RemainSum { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Story { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public string ImageStorageName { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reward> Rewards { get; set; }
        public List<Rating> Ratings { get; set; }

    }
}
