using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models.ViewModels
{
    public class AchievementListViewModel
    {
        public List<Achievement> Achievements { get; set; }
        public List<AchievementViewModel> AchievementViews { get; set; }
    }
}
