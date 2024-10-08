﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Сrowdfunding.CloudStorage;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Сrowdfunding.Hubs;
using Сrowdfunding.Models;
using Сrowdfunding.Models.ViewModels;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Сrowdfunding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _notyfService;
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private readonly IHubContext<CommentHub> _commentHub;
        private readonly IHubContext<NewsHub> _newsHub;
        private ICloudStorage _cloudStorage;

        public HomeController(
            ILogger<HomeController> logger, 
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager, 
            IHubContext<CommentHub> commentHub, 
            IHubContext<NewsHub> newsHub,
            ICloudStorage cloudStorage,
            INotyfService notyfService)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _commentHub = commentHub;
            _newsHub = newsHub;
            _cloudStorage = cloudStorage;
            _notyfService = notyfService;
        }


        public IActionResult Index()
        {
            var campaigns = _context.Campaigns.OrderByDescending(x => x.Ratings.Select(r => r.Rate).Sum() / x.Ratings.Count).ToList();
            var indexVm = new IndexViewModel
            {
                Campaigns = campaigns
            };
            return View(indexVm);
        }


        [HttpGet]
        public IActionResult GetComments()
        {
            var comments = _context.Comments.OrderByDescending(x => x.PostDate).ToList();
            bool isModer = this.User.IsInRole("Admin") || this.User.IsInRole("Moderator");
            var username = _userManager.GetUserName(this.User);
            var users = _userManager.Users.ToList();
            return Ok(new { Comments = comments, IsModer = isModer, Username = username, Users = users });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            _logger.LogInformation(DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss"));
            var campaign = _context.Campaigns.Find(id);
            var achieveGood = new UserAchievementsModel
            {
                UserId = _userManager.GetUserId(this.User),
                AchievementId = _context.Achievements.Where(x => x.Name == "Good start").First().Id,
                GetDate = DateTime.Now
            };
            var achieveSad = new UserAchievementsModel
            {
                UserId = _userManager.GetUserId(this.User),
                AchievementId = _context.Achievements.Where(x => x.Name == "It could be worse...").First().Id,
                GetDate = DateTime.Now
            };
            var isUserHasAcvhieveGood = _context.UserAchievements.Where(x => x.UserId == achieveGood.UserId && x.AchievementId == achieveGood.AchievementId).Any();
            var isUserHasAcvhieveSad = _context.UserAchievements.Where(x => x.UserId == achieveSad.UserId && x.AchievementId == achieveSad.AchievementId).Any();
            
            if (_userManager.GetUserId(this.User) != null && campaign.EndTime < DateTime.Now)
            {
                campaign.Ended = true;
                var isGoodEnd = campaign.RemainSum >= campaign.TotalSum;
                if (!isUserHasAcvhieveGood && isGoodEnd && campaign.Author == _userManager.GetUserName(this.User))
                {                    
                    _context.UserAchievements.Add(achieveGood);
                    _notyfService.Success("You got new achievement!");
                }
                else if (!isUserHasAcvhieveSad && !isGoodEnd)
                {
                    _context.UserAchievements.Add(achieveSad);
                    _notyfService.Success("You got new achievement!");
                }
                _context.SaveChanges();
            } 
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
                var userId = _userManager.GetUserId(this.User);
                comment.PostDate = DateTime.Now;
                comment.Author = username;
                comment.UserId = userId;
                _logger.LogInformation(comment.CampaignId.ToString());
                _context.Add(comment);
                _context.SaveChanges();
                await _commentHub.Clients.All.SendAsync("LoadComments");
                return RedirectToAction("CommentList", new { id = comment.CampaignId });
            }
            return View();
        }

        public PartialViewResult CommentList(int id)
        {
            var commentVm = new CommentViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Comments = _context.Comments.OrderByDescending(x => x.PostDate).ToList(),
                Rating = new Rating
                {
                    CampaignId = id
                }
            };
            return PartialView(commentVm);
        }

        [HttpGet]
        public IActionResult GetNews()
        {
            var news = _context.News.ToList();
            bool isModer = this.User.IsInRole("Admin") || this.User.IsInRole("Moderator");
            var username = _userManager.GetUserName(this.User);
            return Ok(new { News = news, IsModer = isModer, Username = username });
        }

        public async Task<IActionResult> AddNewsAsync(News news)
        {
            news.Author = _userManager.GetUserName(this.User);
            news.PostDate = DateTime.Now;
            news.UserId = _userManager.GetUserId(this.User);
            _context.Add(news);
            _context.SaveChanges();
            await _newsHub.Clients.All.SendAsync("LoadNews");
            return RedirectToAction("NewsList", new { id = news.CampaignId });
        }

        public PartialViewResult NewsList(int id)
        {
            var newsVm = new NewsViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                News = _context.News.ToList()                
            };
            return PartialView(newsVm);
        }

        [HttpGet]
        public IActionResult Rewards(int id)
        {
            var rewardViewModel = new RewardViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Reward = new Reward()
            };
            
            return View(rewardViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RewardsAsync(Reward reward)
        {
            if (ModelState.IsValid)
            {
                if (reward.ImageFile != null)
                {
                    var file = reward.ImageFile;
                    string filePath = await _cloudStorage.GetFilePathAsync(file);
                    var uri = _cloudStorage.UploadImage(filePath);
                    reward.ImageUrl = uri.ToString();
                }
                else
                {
                    reward.ImageUrl = "https://res.cloudinary.com/dwivxsl5s/image/upload/v1621205266/no-img_if8frz.jpg";
                }

                _context.Add(reward);
                _context.SaveChanges();
            }
            
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

            return RedirectToActionPermanent("Details", "Home", new { id = reward.CampaignId });
        }

        [HttpGet]
        public IActionResult Support(int id)
        {
            var supportVm = new SupportViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Rewards = _context.Rewards.Where(x => x.CampaignId == id).ToList()
            };
            
            return View(supportVm);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Support(Reward reward, int id)
        {
            var campaign = _context.Campaigns.Find(id);
            var rew = _context.Rewards.Find(reward.RewardId);
            campaign.RemainSum += reward.Price;

            if (rew.Count > 0)
            {
                rew.Count--;
            }            
            _context.SaveChanges();
            var supportVm = new SupportViewModel
            {
                Campaign = campaign,
                Rewards = _context.Rewards.ToList()
            };

            return View(supportVm);
        }

        [HttpPost]
        [Authorize]
        [Route("Home/Support")]
        public IActionResult SupportByMoney(int id, int sum)
        {
            var campaign = _context.Campaigns.Find(id);
            campaign.RemainSum += sum;
            _context.SaveChanges();

            var supportVm = new SupportViewModel
            {
                Campaign = _context.Campaigns.Find(id),
                Rewards = _context.Rewards.Where(x => x.CampaignId == id).ToList()
            };

            return View("Support", supportVm);
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

        public bool CheckLikes(Comment comment, string username)
        {
            return _context.Likes
                    .Where(like => like.CommentId == comment.CommentId)
                    .Where(like => like.Username == username)
                    .Any();
        }

        public bool CheckDislikes(Comment comment, string username)
        {
            return _context.Dislikes
                    .Where(dislike => dislike.CommentId == comment.CommentId)
                    .Where(dislike => dislike.Username == username)
                    .Any();
        }

        public void DecreaseLikes(Comment comment, string username, Comment dbComment)
        {
            var like = _context.Likes
                   .Where(l => l.CommentId == comment.CommentId)
                   .Where(l => l.Username == username)
                   .FirstOrDefault();
            _context.Likes.Remove(like);
            dbComment.LikesCount--;
        }

        public void DecreaseDislikes(Comment comment, string username, Comment dbComment)
        {
            var dislike = _context.Dislikes
                       .Where(d => d.CommentId == comment.CommentId)
                       .Where(d => d.Username == username)
                       .FirstOrDefault();
            _context.Dislikes.Remove(dislike);
            dbComment.DislikesCount--;
        }

        [Authorize]
        public IActionResult Like(Comment comment)
        {
            _logger.LogError("like:" + comment.CommentId.ToString() + "; " + comment.CampaignId.ToString());
            var username = _userManager.GetUserName(this.User);
            var userId = _userManager.GetUserId(this.User);
            var dbComment = _context.Comments.Find(comment.CommentId);
            var newLike = new Like
            {
                CommentId = comment.CommentId,
                Username = username,
                UserId = userId
            };
            if (CheckLikes(comment, username))
            {
                DecreaseLikes(comment, username, dbComment);
            }
            else
            {
                if (CheckDislikes(comment, username))
                {
                    DecreaseDislikes(comment, username, dbComment);
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
            var userId = _userManager.GetUserId(this.User);
            var dbComment = _context.Comments.Find(comment.CommentId);
            var newDislike = new Dislike
            {
                CommentId = comment.CommentId,
                Username = username,
                UserId = userId
            };
            if (CheckDislikes(comment, username))
            {
                DecreaseDislikes(comment, username, dbComment);
            }
            else
            {
                if (CheckLikes(comment, username))
                {
                    DecreaseLikes(comment, username, dbComment);
                }
                _context.Dislikes.Add(newDislike);
                dbComment.DislikesCount++;
            }
            _context.SaveChanges();
            return RedirectToAction("CommentList", new { id = comment.CampaignId });
        }

        public IActionResult DeleteComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Remove(_context.Comments.Find(comment.CommentId));
                _context.SaveChanges();
            }
            return RedirectToAction("CommentList", new { id = comment.CampaignId });
        }

        public IActionResult DeleteNews(News news)
        {
            if (ModelState.IsValid)
            {
                _context.News.Remove(_context.News.Find(news.NewsId));
                _context.SaveChanges();
            }
            return RedirectToAction("NewsList", new { id = news.CampaignId });
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
