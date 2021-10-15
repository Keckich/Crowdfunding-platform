using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Models;
using Сrowdfunding.Models.ViewModels;

namespace Сrowdfunding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            var campaigns = _context.Campaigns.ToList();
            var indexVm = new IndexViewModel
            {
                Campaigns = campaigns
            };
            return View(indexVm);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Comments = _context.Comments.ToList()
            };
            return View(commentVm);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Details(Comment comment, int id)
        {
            if (ModelState.IsValid)
            {
                comment.PostDate = DateTime.Now;
                comment.Author = _userManager.GetUserName(this.User);
                _logger.LogInformation(comment.CampaignId.ToString());
                _context.Add(comment);
                _context.SaveChanges();

                var commentVm = new CommentViewModel
                {
                    Campaign = _context.Campaigns.Find(id),
                    Comments = _context.Comments.ToList()
                };
                return View("Details", commentVm);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Rewards(int id)
        {
            var campaign = _context.Campaigns.Find(id);
            return View(campaign);
        }

        [HttpPost]
        public IActionResult Rewards(Reward reward)
        {
            _context.Add(reward);
            _context.SaveChanges();
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(reward.CampaignId),
                Comments = _context.Comments.ToList()
            };
            return View("Details", commentVm);
        }

        [HttpGet]
        public IActionResult Support(int id)
        {
            var supportVm = new SupportViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Rewards = _context.Rewards.ToList()
            };
            
            return View(supportVm);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
