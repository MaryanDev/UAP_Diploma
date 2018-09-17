using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PFSC.Models.Enums;
using PFSC.Services.Abstract.FactoryAdminDashboard;

namespace PFSC.WebUI.Controllers
{
    public class FactoryAdminDashboardController : Controller
    {
        private IFactoryAdminDasboardService _dasboardService;
        public FactoryAdminDashboardController(IFactoryAdminDasboardService dasboardService)
        {
            this._dasboardService = dasboardService;
        }

        [Authorize(Roles = "Admin,FactoryAdmin")]
        public IActionResult Index()
        {
            var dashboardModel = _dasboardService.BuildDasboardModel(1);
            return View(dashboardModel);
        }

        public IActionResult AdminSummary()
        {
            return PartialView();
        }

        public IActionResult Profile()
        {
            return PartialView();
        }

        public IActionResult MainTable()
        {
            return PartialView();
        }

        public IActionResult Map()
        {
            return PartialView();
        }
    }
}