using PFSC.Models.FactoryAdminDashboard;

namespace PFSC.Services.Abstract.FactoryAdminDashboard
{
    public interface IFactoryAdminDasboardService
    {
        DashboardModel BuildDasboardModel(int factoryId, string userName);
    }
}
