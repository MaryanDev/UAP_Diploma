using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Services.Abstract.Search;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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

        [HttpGet]
        public JsonResult FactoriesForAutocomplete(string searchCriteria)
        {
            var matchedFactories = _searchService.SearchFactoriesShort(searchCriteria);
            return Json(matchedFactories);
            //return PartialView(matchedFactories);
        }

        public JsonResult SearchFactories()
        {
            return Json(_searchService.SearchFactories());
        }
    }
}