using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сrowdfunding.Models.ViewModels
{
    public class SearchViewModel
    {
        public List<Campaign> Campaigns { get; set; }

        public string SearchString { get; set; }
    }
}
