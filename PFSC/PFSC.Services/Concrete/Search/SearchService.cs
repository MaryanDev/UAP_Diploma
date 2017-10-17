using PFSC.Entities.PFSC_DBContext;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PFSC.Entities.Entites;
using PFSC.Models.Search;

namespace PFSC.Services.Concrete.Search
{
    public class SearchService : BaseService, ISearchService
    {
        public SearchService(PfscDbContext context) : base(context)
        {

        }

        public List<CriteriaModel> GetProduction()
        {
            return _context.PrintingProductions.Select(p => new CriteriaModel
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description
            }).ToList();
        }

        public List<CriteriaModel> GetTechnologies()
        {
            return _context.PrintingTechnologies.Select(t => new CriteriaModel
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description
            }).ToList();
        }
    }
}
