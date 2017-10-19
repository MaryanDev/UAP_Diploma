using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Services.Abstract.Factory;

namespace PFSC.WebUI.Controllers
{
    public class FactoryController : Controller
    {
        private IFactoryService _factoryService;

        public FactoryController(IFactoryService factoryService)
        {
            _factoryService = factoryService;
        }
        public JsonResult GetFactory(int factoryId)
        {
            var factory = _factoryService.GetFullFactoryInfo(factoryId);
            return Json(factory);
        }
    }
}
