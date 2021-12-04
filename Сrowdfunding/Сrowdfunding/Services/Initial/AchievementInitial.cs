using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Models;

namespace Сrowdfunding.Services.Initial
{
    public class AchievementInitial
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Achievements.Any())
            {
                context.Achievements.AddRange(
                    new Achievement
                    {
                        Name = "That's only the beginning!",
                        Description = "Start your first campaign.",
                        ImageUrl = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1638577717/beginning_lq3ix6.png"
                    },
                    new Achievement
                    {
                        Name = "Good start",
                        Description = "Successfully complete your first campaign.",
                        ImageUrl = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1638577690/goodstart_vyugie.png"
                    },
                    new Achievement
                    {
                        Name = "It could be worse...",
                        Description = "Get less money than goal for your campaign",
                        ImageUrl = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1638577703/sad_ixnmrt.png"
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
