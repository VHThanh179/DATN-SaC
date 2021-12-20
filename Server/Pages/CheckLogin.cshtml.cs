using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Share.Models;
using Share.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Share.Interfaces;

namespace Server.Pages
{
    [AllowAnonymous]
    public class CheckLoginModel : PageModel
    {
        [Inject]
        public IUserSvc _userService { get; set; }
        public IActivity _activitySvc { get; set; }
        public static string role { get; set; }
        public CheckLoginModel(IUserSvc userSvc, IActivity activitySvc)
        {
            _userService = userSvc;
            _activitySvc = activitySvc;
        }
        public string ReturnUrl { get; set; }
        public async Task<IActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception) { }
            bool flagLogin = false;
            var viewLogin = new ViewLogin() { UserName = paramUsername, Password = paramPassword };
            User user = _userService.Login(viewLogin);
            if (user != null)
            {
                flagLogin = true;
                role = user.Roles.ToString();
            }
            if (flagLogin)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(ClaimTypes.Role, user.Roles.ToString())
                };
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = false,
                    RedirectUri = this.Request.Host.Value
                };
                try
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimIdentity), authProperties);
                    _activitySvc.SaveLog(user.UserName);
                }
                catch (Exception e)
                {
                    string err = e.Message;
                }
            }
            else { }
            return LocalRedirect(returnUrl);
        }
    }
}