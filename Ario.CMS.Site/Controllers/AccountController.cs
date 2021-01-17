using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ario.CMS.ViewModel.Account;
using Microsoft.AspNetCore.Identity;

namespace Ario.CMS.Site.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            ViewData["return"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["return"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe,
                    lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(returnUrl);
                }

                if (result.IsLockedOut)
                {
                    return View("LockOut");
                }

                ModelState.AddModelError(string.Empty, "رمز ورود یا نام کاربری اشتباه است");
            }

            return View();
        }
    }
}
