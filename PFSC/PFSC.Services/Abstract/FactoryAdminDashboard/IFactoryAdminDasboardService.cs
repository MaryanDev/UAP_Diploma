using PFSC.Models.FactoryAdminDashboard;
using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Services.Abstract.FactoryAdminDashboard
{
    public interface IFactoryAdminDasboardService
    {
        DashboardModel BuildDasboardModel(int factoryId);
    }
}
