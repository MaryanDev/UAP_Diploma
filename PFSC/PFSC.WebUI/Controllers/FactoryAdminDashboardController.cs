using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PFSC.Models.Enums;

namespace PFSC.WebUI.Controllers
{
    public class FactoryAdminDashboardController : Controller
    {
        public FactoryAdminDashboardController()
        {

        }
        [Authorize(Roles = "Admin,FactoryAdmin")]
        public IActionResult Index()
        {
            return View();
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