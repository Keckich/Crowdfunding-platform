using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models
{
    public class UserAchievementsModel
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int AchievementId { get; set; }
        public DateTime GetDate { get; set; }
        public ApplicationUser User { get; set; }
        public Achievement Achievement { get; set; }
    }
}
