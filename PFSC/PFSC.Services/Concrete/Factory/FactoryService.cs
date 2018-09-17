using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PFSC.Entities.Entites;
using PFSC.Entities.Migrations;
using PFSC.Entities.PFSC_DBContext;
using PFSC.Models.Common;
using PFSC.Models.Factory;
using PFSC.Models.Home;
using PFSC.Models.Search;
using PFSC.Models.User;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.Factory;

namespace PFSC.Services.Concrete.Factory
{
    public class FactoryService : BaseService, IFactoryService
    {
        public FactoryService(PfscDbContext context) : base(context)
        {

        }

        public FactoryModel GetFullFactoryInfo(int factoryId)
        {
            return
                _context.Factories.Include(f => f.FactoryImages)
                    .Include(f => f.Machines)
                    .ThenInclude(m => m.Machine)
                    .ThenInclude(m => m.Manufacturer)
                    .Include(f => f.Production)
                    .ThenInclude(p => p.Production)
                    .Include(f => f.Ratings)
                    .ThenInclude(r => r.User)
                    .Include(f => f.Reviews)
                    .ThenInclude(r => r.ReviewResult)
                    .Include(f => f.District)
                    .Include(f => f.WorkingHours)
                    .Select(f => new FactoryModel
                    {
                        Id = f.Id,
                        Title = f.Title,
                        Address = f.Address,
                        CountOfEmployees = f.CountOfEmplyees,
                        DateCreated = f.DateCreated,
                        Description = f.Description,
                        Rating = f.Ratings.Average(r => r.RankValue),
                        SiteUrl = f.SiteUrl,
                        Location = new Location
                        {
                            Lattitude = f.Lattitude.Value,
                            Longitude = f.Longittude.Value
                        },
                        District = f.District.Title,
                        FactoryImages = f.FactoryImages.Select(fi => string.IsNullOrEmpty(fi.Path) ? "/Content/Images/default-img.gif" : fi.Path),
                        Machines = f.Machines.Select(m => new Models.Factory.MachineModel
                        {
                            Id = m.Machine.Id,
                            Title = m.Machine.Title,
                            Manufacturer = m.Machine.Manufacturer.Title,
                            Description = m.Machine.Description
                        }),
                        Production = f.Production.Select(p => new CriteriaModel
                        {
                            Id = p.Production.Id,
                            Title = p.Production.Title,
                            Description = p.Production.Description
                        }),
                        Technologies = f.Technologies.Select(t => new CriteriaModel
                        {
                            Id = t.PrintingTechnology.Id,
                            Title = t.PrintingTechnology.Title,
                            Description = t.PrintingTechnology.Description
                        }),
                        Reviews = f.Reviews.Select(r => new ReviewModel
                        {
                            Id = r.Id,
                            Title = r.Title,
                            Text = r.Text,
                            DateCreated = r.DateCreated,
                            ReviewResulDescription = r.ReviewResult.Description,
                            ReviewResultTitle = r.ReviewResult.Title,
                            User = new UserModel
                            {
                                Id = r.User.Id,
                                AvatarPath = r.User.AvatarPath,
                                DateOfBirth = r.User.DateOfBirth,
                                Email = r.User.Email,
                                FirstName = r.User.FirstName,
                                LastName = r.User.LastName
                            }
                        }),
                        WorkingHours = f.WorkingHours.Select(wh => new WorkingHoursModel
                        {
                            DayOfWeek = ((DayOfWeek)wh.DayOfWeek).ToString(),
                            FromTime = wh.FromTime,
                            ToTime = wh.ToTime
                        })
                    })
                    .FirstOrDefault(f => f.Id == factoryId);
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
