using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PFSC.Models.Enums;
using PFSC.Models.User;
using PFSC.Services.Abstract.FactoryAdminDashboard;
using PFSC.Services.Abstract.Security;

namespace PFSC.WebUI.Controllers
{
    [Authorize]
    public class FactoryAdminDashboardController : Controller
    {
        private readonly IFactoryAdminDasboardService _dasboardService;
        private readonly IPfscAuthenticationService _authService;
        public FactoryAdminDashboardController(IFactoryAdminDasboardService dasboardService, IPfscAuthenticationService authService)
        {
            this._dasboardService = dasboardService;
            this._authService = authService;
        }

        [Authorize(Roles = "Admin,FactoryAdmin")]
        public IActionResult Index()
        {
            var dashboardModel = _dasboardService.BuildDasboardModel(1, User.Identity.Name);
            dashboardModel.DashboardUser = _authService.GetCurrentUserInfo(User.Identity.Name);
            return View(dashboardModel);
        }

        public IActionResult AdminSummary()
        {
            var dashboardModel = _dasboardService.BuildDasboardModel(1, User.Identity.Name);

            return PartialView(dashboardModel);
        }

        [HttpGet]
        public IActionResult Profile()
        {
            var user = this._authService.GetCurrentUserInfo(User.Identity.Name);
            return PartialView(user);
        }

        [HttpPost]
        public IActionResult Profile(UserModel usermodel)
        {
            var user = _authService.UpdateUser(usermodel, User.Identity.Name);
            return PartialView(user);
        }


        public IActionResult MainTable()
        {
            var machines = _dasboardService.BuildDasboardModel(1, User.Identity.Name).PrintingMachines;
            return PartialView(machines);
        }

        public IActionResult Map()
        {
            return PartialView();
        }

        public IActionResult Media()
        {
            return PartialView();
        }
    }
}