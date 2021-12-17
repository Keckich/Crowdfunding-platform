using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Сrowdfunding.Data;
using Сrowdfunding.Models;

namespace Сrowdfunding.Areas.Identity.Pages.Account.Manage
{
    public class UsersModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;
        private readonly ILogger<UsersModel> _logger;

        [TempData]
        public string StatusMessage { get; set; }

        public InputUser InUser { get; set; }

        public UsersModel(ILogger<UsersModel> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
        }

        public class InputUser
        {
            public List<ApplicationUser> Users { get; set; }
        }

        public IActionResult OnGet()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            if (this.User.IsInRole("Admin"))
            {
                users = _userManager.Users.Where(x => x.Id != _userManager.GetUserAsync(this.User).Result.Id).ToList();
            }
            InUser = new InputUser
            {
                Users = users
            };

            return Page();
        }

        public async Task<IActionResult> OnPostDelete(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            await _userManager.DeleteAsync(user);
            
            await _context.SaveChangesAsync();
            List<ApplicationUser> users = _userManager.Users.ToList();
            InUser = new InputUser
            {
                Users = users
            };
            StatusMessage = "User has been deleted.";

            return RedirectToPage();
        }
    }
}
