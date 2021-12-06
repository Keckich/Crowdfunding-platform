using AspNetCoreHero.ToastNotification.Abstractions;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.CloudStorage;
using Сrowdfunding.Data;
using Сrowdfunding.Models;
using Сrowdfunding.Models.ViewModels;

namespace Сrowdfunding.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ILogger<CampaignController> _logger;
        private readonly INotyfService _notyfService;
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private ICloudStorage _cloudStorage;

        public CampaignController(
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager, 
            ICloudStorage cloudStorage, 
            ILogger<CampaignController> logger,
            INotyfService notyfService)
        {
            _context = context;
            _userManager = userManager;
            _cloudStorage = cloudStorage;
            _logger = logger;
            _notyfService = notyfService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var createVm = new CreateCampaignViewModel
            {
                Campaign = new Campaign(),
                Categories = _context.Categories.ToList()
            };
            return View(createVm);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                if (campaign.ImageFile != null)
                {                    
                    var file = campaign.ImageFile;   
                    string filePath = await _cloudStorage.GetFilePathAsync(file);          
                    var uri = _cloudStorage.UploadImage(filePath);
                    campaign.ImageUrl = uri.ToString();
                }
                else
                {
                    campaign.ImageUrl = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1621205266/no-img_if8frz.jpg";
                }
                
                campaign.Author = _userManager.GetUserName(this.User);
                campaign.UserId = _userManager.GetUserId(this.User);
                campaign.BeginTime = DateTime.Now;
                campaign.RemainSum = 0;
                var achieve = new UserAchievementsModel
                {
                    UserId = _userManager.GetUserId(this.User),
                    AchievementId = _context.Achievements.Where(x => x.Name == "That's only the beginning!").First().Id,
                    GetDate = DateTime.Now
                };
                var campaignsCurrentUserCount = _context.Campaigns.Where(x => x.Author == campaign.Author).Count();
                var isUserHasAcvhieve = _context.UserAchievements.Where(x => x.UserId == achieve.UserId && x.AchievementId == achieve.AchievementId).Any();
                if (!isUserHasAcvhieve && campaignsCurrentUserCount < 1)
                {
                    _context.UserAchievements.Add(achieve);
                    _notyfService.Success("You got new achievement!");
                }
                _context.Campaigns.Add(campaign);
                _context.SaveChanges();
            }
            return RedirectPermanent("~/Home/Index");
        }
    }
}
