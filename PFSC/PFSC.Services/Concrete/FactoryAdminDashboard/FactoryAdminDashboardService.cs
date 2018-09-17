using PFSC.Entities.PFSC_DBContext;
using PFSC.Models.FactoryAdminDashboard;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.FactoryAdminDashboard;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.Factory;
using PFSC.Entities.Entites;

namespace PFSC.Services.Concrete.FactoryAdminDashboard
{
    public class FactoryAdminDashboardService : BaseService, IFactoryAdminDasboardService
    {
        public FactoryAdminDashboardService(PfscDbContext context) : base(context)
        {
        }

        public DashboardModel BuildDasboardModel(int factoryId)
        {
            var dashboardModel = new DashboardModel();
            var factory = _context.Factories.FirstOrDefault(f => f.Id == factoryId);
            if (factory != null)
            {

            }
            return dashboardModel;
        }
    }
}
