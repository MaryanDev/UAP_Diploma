using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PFSC.WebUI.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(int param = 0)
        {
            return View();
        }
    }
}