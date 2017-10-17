using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PFSC.Entities.Entites;
using PFSC.Entities.Migrations;
using PFSC.Entities.PFSC_DBContext;
using PFSC.Models.Home;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.Factory;

namespace PFSC.Services.Concrete.Factory
{
    public class FactoryService : BaseService, IFactoryService
    {
        public FactoryService(PfscDbContext context) : base(context)
        {

        }

        public IEnumerable<TopRatedFactoryInfo> GetTopRated()
        {
            var topRated =
                _context.Ratings.Include(r => r.Factory)
                    .GroupBy(r => r.FactoryId)
                    .OrderByDescending(r => r.Average(a => a.RankValue))
                    .Take(3)
                    .Select(e => new TopRatedFactoryInfo
                    {
                        Title = _context.Factories.FirstOrDefault(f => f.Id == e.Key).Title,
                        Image = _context.FactoryImages.FirstOrDefault(f => f.FactoryId == e.Key).Path
                    })
                    .ToList();

            //var topRated1 = from f in _context.Factories.Include(f => f.FactoryImages)
            //    join r in _context.Ratings
            //    on f.Id equals r.FactoryId
            //    group r by r.FactoryId
            //    into newRating
            //    let averageRating = newRating.Average(n => n.RankValue)
            //    let factory = newRating.FirstOrDefault(n => n.FactoryId == newRating.Key).Factory
            //    orderby averageRating descending
            //    select
            //    new TopRatedFactoryInfo {Title = factory.Title, Image = factory.FactoryImages.FirstOrDefault().Path};

            //return topRated1.Take(4).ToList();

            return topRated;
        }
    }
}
