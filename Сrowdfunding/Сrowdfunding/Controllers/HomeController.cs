using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Hubs;
using Сrowdfunding.Models;
using Сrowdfunding.Models.ViewModels;

namespace Сrowdfunding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private readonly IHubContext<CommentHub> _commentHub;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager, IHubContext<CommentHub> commentHub)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _commentHub = commentHub;
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
        public IActionResult GetComments()
        {
            var res = _context.Comments.ToList();
            return Ok(res);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            _logger.LogInformation(DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss"));
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Comments = _context.Comments.ToList(),
                Rating = new Rating
                {
                    CampaignId = id
                }
            };
            return View(commentVm);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DetailsAsync(Comment comment, int id)
        {

            if (ModelState.IsValid)
            {
                _logger.LogError("IN DETAILS");
                var username = _userManager.GetUserName(this.User);
                comment.PostDate = DateTime.Now;
                comment.Author = username;
                _logger.LogInformation(comment.CampaignId.ToString());
                _context.Add(comment);
                _context.SaveChanges();
                await _commentHub.Clients.All.SendAsync("LoadComments");
                
                //return View("Details", commentVm);
                return RedirectToAction("CommentList", new { id = id });
            }
            return View();
        }

        public PartialViewResult CommentList(int id)
        {
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Comments = _context.Comments.ToList(),
                Rating = new Rating
                {
                    CampaignId = id
                }
            };
            return PartialView(commentVm);
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
            var username = _userManager.GetUserName(this.User);
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(reward.CampaignId),
                Comments = _context.Comments.ToList(),
                Rating = new Rating
                {
                    CampaignId = reward.CampaignId,
                    Username = username
                }
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

        [HttpPost]
        [Authorize]
        public IActionResult Support(Reward reward, int id)
        {
            var campaign = _context.Campaigns.Find(id);
            var rew = _context.Rewards.Find(reward.RewardId);
            campaign.RemainSum -= reward.Price;
            rew.Count--;
            _context.SaveChanges();
            var supportVm = new SupportViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Rewards = _context.Rewards.ToList()
            };
            return View(supportVm);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Rate(Rating rating)
        {
            //_logger.LogError("rating:" + rating.ToString());
            var username = _userManager.GetUserName(this.User);
            var ratings = _context.Ratings.Where(rate => rate.Username == username && rate.CampaignId == rating.CampaignId).ToList();
            if (ratings.Count() == 0)
            {
                rating.Username = username;
                _context.Add(rating);
                _context.SaveChanges();
            }
            return RedirectToAction("_RatingPartial", new { id = rating.RateId });
        }

        public PartialViewResult _RatingPartial(int id)
        {
            return PartialView(_context.Ratings.Find(id));
        }

        [Authorize]
        public IActionResult Like(Comment comment)
        {
            _logger.LogError("like:" + comment.CommentId.ToString() + "; " + comment.CampaignId.ToString());
            var username = _userManager.GetUserName(this.User);
            var dbComment = _context.Comments.Find(comment.CommentId);
            var newLike = new Like
            {
                CommentId = comment.CommentId,
                Username = username
            };
            if (_context.Likes
                .Where(like => like.CommentId == comment.CommentId)
                .Where(like => like.Username == username)
                .Any())
            {
                var like = _context.Likes
                   .Where(l => l.CommentId == comment.CommentId)
                   .Where(l => l.Username == username)
                   .FirstOrDefault();
                _context.Likes.Remove(like);
                dbComment.LikesCount--;
            }
            else
            {
                if (_context.Dislikes
                    .Where(dislike => dislike.CommentId == comment.CommentId)
                    .Where(dislike => dislike.Username == username)
                    .Any())
                {
                    var dislike = _context.Dislikes
                       .Where(d => d.CommentId == comment.CommentId)
                       .Where(d => d.Username == username)
                       .FirstOrDefault();
                    _context.Dislikes.Remove(dislike);
                    dbComment.DislikesCount--;
                }
                _context.Likes.Add(newLike);
                dbComment.LikesCount++;
            }
            _context.SaveChanges();
            return RedirectToAction("CommentList", new { id = comment.CampaignId });
        }

        [Authorize]
        public IActionResult Dislike(Comment comment)
        {
            var username = _userManager.GetUserName(this.User);
            var dbComment = _context.Comments.Find(comment.CommentId);
            var newDislike = new Dislike
            {
                CommentId = comment.CommentId,
                Username = username
            };
            if (_context.Dislikes
                .Where(dislike => dislike.CommentId == comment.CommentId)
                .Where(dislike => dislike.Username == username)
                .Any())
            {
                var dislike = _context.Dislikes
                   .Where(d => d.CommentId == comment.CommentId)
                   .Where(d => d.Username == username)
                   .FirstOrDefault();
                _context.Dislikes.Remove(dislike);
                dbComment.DislikesCount--;
            }
            else
            {
                if (_context.Likes
                    .Where(like => like.CommentId == comment.CommentId)
                    .Where(like => like.Username == username)
                    .Any())
                {
                    var like = _context.Likes
                       .Where(l => l.CommentId == comment.CommentId)
                       .Where(l => l.Username == username)
                       .FirstOrDefault();
                    _context.Likes.Remove(like);
                    dbComment.LikesCount--;
                }
                _context.Dislikes.Add(newDislike);
                dbComment.DislikesCount++;
            }
            _context.SaveChanges();
            return RedirectToAction("CommentList", new { id = comment.CampaignId });
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
