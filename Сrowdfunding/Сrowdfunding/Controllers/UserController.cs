﻿using Microsoft.AspNetCore.Identity;
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
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public UserController(
            ILogger<UserController> logger,
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var achievements = _context.UserAchievements.Where(x => x.UserId == user.Id).Select(x => x.AchievementId).ToList();

            var userInfoViewModel = new UserInfoViewModel{
                User = user,
                Campaigns = _context.Campaigns.Where(x => x.UserId == user.Id).ToList(),
                Achievements = _context.Achievements.Where(x => achievements.Contains(x.Id)).ToList()
            };

            return View(userInfoViewModel);
        }
    }
}
