using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Entities.Entites;
using PFSC.Models.Security;
using PFSC.Services.Abstract.Security;

namespace PFSC.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPfscAuthenticationService _authenticationService;

        public AccountController(IPfscAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (_authenticationService.Login(loginModel))
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Incorrect login or password");
            }
            return View(loginModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = _authenticationService.Register(registerModel);
                if (newUser != null)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Something gone wrong, please try later");
            }
            return View(registerModel);
        }


        public IActionResult Logout()
        {
            _authenticationService.Logout();
            return RedirectToAction("Login", "Account");
        }
    }
}
