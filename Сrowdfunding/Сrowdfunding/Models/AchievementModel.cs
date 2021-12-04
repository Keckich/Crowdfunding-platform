using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<UserAchievementsModel> UserAchievements { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public string ImageStorageName { get; set; }
    }
}
