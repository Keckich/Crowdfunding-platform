using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Models;

namespace Сrowdfunding.Controllers
{
    public class CampaignController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;
        public CampaignController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View(_context.Categories.ToList());
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                campaign.Author = _userManager.GetUserName(this.User);
                campaign.BeginTime = DateTime.Now;
                _context.Campaigns.Add(campaign);
                _context.SaveChanges();
            }
            return RedirectPermanent("~/Home/Index");
        }
    }
}
