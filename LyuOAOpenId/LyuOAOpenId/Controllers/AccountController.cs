using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.UI;
using Abp.Zero.Authorization.Users;
using Lyu.Core.Domin.Users;
using LyuOAOpenId.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace LyuOAOpenId.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager _userManager;
        
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public AccountController(UserManager userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Login()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Login(LoginViewModel loginModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var loginResult = await _userManager.LoginAsync(
               loginModel.Username,
               loginModel.Password
               );

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    break;
                case AbpLoginResultType.InvalidUserNameOrEmailAddress:
                case AbpLoginResultType.InvalidPassword:
                    ViewData["message"] = "Invalid user name or password!";
                    throw new UserFriendlyException("Invalid user name or password!");
                case AbpLoginResultType.UserIsNotActive:
                    throw new UserFriendlyException("User is not active: " + loginModel.Username);
                case AbpLoginResultType.UserEmailIsNotConfirmed:
                    throw new UserFriendlyException("Your email address is not confirmed!");
                default: //Can not fall to default for now. But other result types can be added in the future and we may forget to handle it
                    throw new UserFriendlyException("Unknown problem with login: " + loginResult.Result);
            }

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = true }, loginResult.Identity);

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("AskUser", "OpenId");
        }
    }
}