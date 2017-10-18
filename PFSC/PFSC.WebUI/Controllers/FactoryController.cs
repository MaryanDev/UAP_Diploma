using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PFSC.WebUI.Controllers
{
    public class FactoryController : Controller
    {
        public ActionResult Index(int factoryId)
        {
            return View();
        }
    }
}
