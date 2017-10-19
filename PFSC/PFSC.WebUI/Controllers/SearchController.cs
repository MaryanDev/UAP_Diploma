using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFSC.Services.Abstract.Search;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PFSC.Services.Abstract.Base;

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

        public JsonResult SearchFactories(int page = 1)
        {
            var factories = _searchService.SearchFactories(page);
            var count = GetCountOfPages(_searchService.GetCountOfFactories(), 4);
            return Json(new { factories= factories, allPages = count, currentPage = page });
        }
        protected int GetCountOfPages(int allPages, int size)
        {
            var pages = allPages / size;
            var count = allPages % size == 0 ? pages : ++pages;
            return count;
        }
    }
}