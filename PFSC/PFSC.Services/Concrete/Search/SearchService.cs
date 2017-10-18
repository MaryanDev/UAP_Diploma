using PFSC.Entities.PFSC_DBContext;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PFSC.Entities.Entites;
using PFSC.Models.Search;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

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

        public List<FactoryShortModel> SearchFactoriesShort(string searchQuery)
        {
            return _context.Factories.Include(f => f.FactoryImages)
                .Where(f => f.Title.Contains(searchQuery) || f.Address.Contains(searchQuery))
                .Select(f => new FactoryShortModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    Address = f.Address,
                    Avatar = f.FactoryImages.FirstOrDefault().Path
                }).ToList();
        }

        public List<SearchFactoryModel> SearchFactories()
        {
            return _context.Factories
                .Include(f => f.FactoryImages)
                .Include(f => f.Ratings)
                .Take(4)
                .Select(f => new SearchFactoryModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    Description = f.Description,
                    Avatar = f.FactoryImages.FirstOrDefault().Path,
                    Address = f.Address,
                    Rating = f.Ratings.Average(r => r.RankValue)
                }).ToList();
        }
    }
}
