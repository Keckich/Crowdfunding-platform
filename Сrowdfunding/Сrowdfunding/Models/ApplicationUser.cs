using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserAchievementsModel> UserAchievements { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
        public string ImageUrl { get; set; } = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1638642467/defaultuser_kr3x61.png";
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
    }
}
