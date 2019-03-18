﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using WebShop.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebShop.Controllers
{


  public class AccountController : Controller
  {
    private readonly UserManager<ShopUser> _userManager;
    private readonly SignInManager<ShopUser> _signInManager;
    public AccountController(UserManager<ShopUser> userManager, SignInManager<ShopUser> signInManager)
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
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            ShopUser user = new ShopUser { Email = model.Email, UserName = model.UserName };

            if (user.UserName[user.UserName.IndexOf(' ') + 1] == ' ' ||
                user.UserName[0] == ' '
                )
            { ModelState.AddModelError(string.Empty, "Invalid name."); }
            else
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login and (or) Password");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}