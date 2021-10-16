using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сrowdfunding.Data;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Сrowdfunding.CloudStorage;
using Сrowdfunding.Models;
using Сrowdfunding.Hubs;

namespace Сrowdfunding
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            }
            else //Production
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionProd")));
            }
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddAuthentication()
                    .AddGoogle(options =>
                    {
                        IConfigurationSection googleAuthNSection =
                             Configuration.GetSection("Authentication:Google");
                        options.ClientId = "102145220985-utd9mhqgbamgu1tjiutlquis49t125bg.apps.googleusercontent.com";
                        options.ClientSecret = "o3paVzEAy8VRqH0RF0d8UKPt";
                    })
                    .AddTwitter(options =>
                    {
                        options.ConsumerKey = "9iGXRjBEfQ5v96uypzvKukgQ1";
                        options.ConsumerSecret = "TWiFCyDQh1pGqtoNruWW4tUcaVnDQ9cgJkSqmRlVIB3m34jOGA";
                        options.RetrieveUserDetails = true;
                    })
                    .AddOAuth("GitHub", "GitHub", options => {
                        options.ClientId = "3f2f88bcde7f5e148a0a";
                        options.ClientSecret = "8f60512f87f7a7ef9c64287910d8b0a7c3116d88";
                        options.CallbackPath = new Microsoft.AspNetCore.Http.PathString("/signin-github");
                        options.AuthorizationEndpoint = "https://github.com/login/oauth/authorize";
                        options.TokenEndpoint = "https://github.com/login/oauth/access_token";
                        options.UserInformationEndpoint = "https://api.github.com/user";
                        options.SaveTokens = true;
                        //options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
                        options.ClaimActions.MapJsonKey(ClaimTypes.Name, "login");
                        options.ClaimActions.MapJsonKey("urn:github:name", "name");
                        options.ClaimActions.MapJsonKey(ClaimTypes.Email, "email", ClaimValueTypes.Email);
                        options.ClaimActions.MapJsonKey("urn:github:url", "url");
                        
                    })
                    .AddOAuth("VK", "VK", options => {
                        options.ClientId = "7840968";
                        options.ClientSecret = "84TI0mhRElH8mVfHrLb5";
                        options.ClaimsIssuer = "VKontakte";
                        options.CallbackPath = new Microsoft.AspNetCore.Http.PathString("/signin-vk");
                        options.AuthorizationEndpoint = "https://oauth.vk.com/authorize";
                        options.TokenEndpoint = "https://oauth.vk.com/access_token";
                        options.Scope.Add("email");
                        /*options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "Id");

                        options.ClaimActions.MapJsonKey(ClaimTypes.Name, "Email", ClaimValueTypes.Email);
                        options.ClaimActions.MapJsonKey(ClaimTypes.Email, "Email", ClaimValueTypes.Email);*/
                        options.SaveTokens = true;

                    }); ;
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR();
            services.AddSingleton<ICloudStorage, GoogleCloudStorage>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "reward",
                    pattern: "Home/Details/{id}/AddRewards",
                    defaults: new { controller = "Home", action = "Rewards"});
                endpoints.MapControllerRoute(
                    name: "support",
                    pattern: "Home/Details/{id}/Support",
                    defaults: new { controller = "Home", action = "Support" });
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<CommentHub>("/CommentHub");
                endpoints.MapRazorPages();
            });
        }
    }
}
