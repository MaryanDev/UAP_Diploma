using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Services.Abstract.Search;
using Newtonsoft.Json;

namespace PFSC.WebUI.Controllers
{
    public class SearchController : Controller
    {
        private ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        public IActionResult Index(int param = 0)
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetProduction()
        {
            return Json(_searchService.GetProduction());
        }
        [HttpGet]
        public JsonResult GetTechnologies()
        {
            return Json(_searchService.GetTechnologies());
        }
    }
}