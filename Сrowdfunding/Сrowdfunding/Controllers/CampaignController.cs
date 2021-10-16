using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private ICloudStorage _cloudStorage;

        public CampaignController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ICloudStorage cloudStorage)
        {
            _context = context;
            _userManager = userManager;
            _cloudStorage = cloudStorage;
        }

        /*private async Task UploadFile(Campaign campaign)
        {
            string fileNameForStorage = FormFileName(campaign.Name, campaign.ImageFile.FileName);
            campaign.ImageUrl = await _cloudStorage.UploadFileAsync(campaign.ImageFile, fileNameForStorage);
            campaign.ImageStorageName = fileNameForStorage;
        }

        private static string FormFileName(string title, string fileName)
        {
            var fileExtension = Path.GetExtension(fileName);
            var fileNameForStorage = $"{title}-{DateTime.Now.ToString("yyyyMMddHHmmss")}{fileExtension}";
            return fileNameForStorage;
        }*/

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
        public async Task<IActionResult> Create(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                /*if (campaign.ImageFile != null)
                {
                    await UploadFile(campaign);
                }*/
                campaign.Author = _userManager.GetUserName(this.User);
                campaign.BeginTime = DateTime.Now;
                campaign.RemainSum = campaign.TotalSum;
                _context.Campaigns.Add(campaign);
                _context.SaveChanges();
            }
            return RedirectPermanent("~/Home/Index");
        }
    }
}
