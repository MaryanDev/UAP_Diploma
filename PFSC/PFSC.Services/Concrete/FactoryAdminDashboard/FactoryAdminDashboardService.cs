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
using PFSC.Services.Abstract.Factory;
using PFSC.Services.Concrete.Factory;

namespace PFSC.Services.Concrete.FactoryAdminDashboard
{
    public class FactoryAdminDashboardService : BaseService, IFactoryAdminDasboardService
    {
        private readonly IFactoryService _factoryService;

        public FactoryAdminDashboardService(PfscDbContext context) : base(context)
        {
            _factoryService = new FactoryService(_context);
        }

        public DashboardModel BuildDasboardModel(int factoryId, string userName)
        {
            DashboardModel dashboardModel = null;
            var factory = _context.Factories.FirstOrDefault(f => f.Id == factoryId);
            if (factory != null)
            {
                dashboardModel = new DashboardModel
                {
                    Reviews = _factoryService.GetReviews(r => r.FactoryId == factoryId),
                    PrintingMachines =
                    _factoryService.GetMachines(m => m.Factories.Select(f => f.FactoryId).Contains(factoryId)),
                    Orders = _factoryService.GetOrders(o => o.FactoryId == factoryId),
                    Notifications = _factoryService.GetNotifications(n => n.FactoryId == factoryId),
                    Employees = _factoryService.GetEmployees(emp => emp.FactoryId == factoryId)
                };
            }
            return dashboardModel;
        }
    }
}
