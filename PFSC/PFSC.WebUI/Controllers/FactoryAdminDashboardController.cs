using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PFSC.WebUI.Controllers
{
    public class FactoryAdminDashboardController : Controller
    {
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