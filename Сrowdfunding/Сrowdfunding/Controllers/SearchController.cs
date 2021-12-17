using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Models;
using Сrowdfunding.Models.ViewModels;

namespace Сrowdfunding.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public SearchController(ILogger<SearchController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string searchString)
        {
            var campaigns = _context.Campaigns
                .Where(c => c.Name.Contains(searchString)
                                                    || c.ShortDescription.Contains(searchString)
                                                    || c.Story.Contains(searchString)
                                                    || c.Comments.Where(com => com.Content.Contains(searchString)).Any()
                                                    || c.News.Where(n => n.NewsContent.Contains(searchString)).Any())
                .OrderByDescending(x => x.Ratings.Select(r => r.Rate).Sum() / x.Ratings.Count)
                .ToList();
            var searchViewModel = new SearchViewModel
            {
                Campaigns = campaigns,
                SearchString = searchString
            };

            return View("Index", searchViewModel);
        }
    }
}
