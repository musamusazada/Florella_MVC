using Florella_MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _userManager.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var changePasswordViewModel = new ChangePasswordViewModel
            {
                Id = user.Id,
                Username = user.Username
            };

            return View(changePasswordViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordViewModel model)
        {
            var user = await _userManager.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var changePasswordViewModel = new ChangePasswordViewModel
            {
                Id = user.Id,
                Username = user.Username
            };
            if (!ModelState.IsValid)
            {
                return View(changePasswordViewModel);
            }

            if(! await _userManager.CheckPasswordAsync(user, model.OldPassword))
            {
                ModelState.AddModelError(nameof(ChangePasswordViewModel.OldPassword), "Old password is incorrect");
                return View(changePasswordViewModel);
            }

            var identityResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (!identityResult.Succeeded)
            {
                foreach(var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(changePasswordViewModel);
            }
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
    }
}
