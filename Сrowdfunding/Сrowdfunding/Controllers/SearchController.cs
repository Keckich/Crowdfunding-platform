using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Models.ViewModels;

namespace Сrowdfunding.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public SearchController(ILogger<SearchController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string searchString)
        {
            var campaigns = _context.Campaigns.Where(c => c.Name.Contains(searchString)
                                                    || c.ShortDescription.Contains(searchString)
                                                    || c.Story.Contains(searchString)
                                                    || c.Comments.Where(com => com.Content.Contains(searchString)).Any()
                                                    || c.News.Where(n => n.NewsContent.Contains(searchString)).Any()).ToList();
            var searchViewModel = new SearchViewModel
            {
                Campaigns = campaigns,
                SearchString = searchString
            };

            return View("Index", searchViewModel);
        }
    }
}
