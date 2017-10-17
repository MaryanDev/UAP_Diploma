using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Services.Abstract.Factory;

namespace PFSC.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IFactoryService _factoryService;

        public HomeController(IFactoryService factoryService)
        {
            _factoryService = factoryService;
        }
        public IActionResult Index()
        {
            var topRated = _factoryService.GetTopRated();
            return View(topRated);
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
