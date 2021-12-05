using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models.ViewModels
{
    public class UserInfoViewModel
    {
        public List<Campaign> Campaigns { get; set; }
        public List<Achievement> Achievements { get; set; }
        public ApplicationUser User { get; set; }

    }
}
