using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Entities.Entites;
using PFSC.Models.Factory;
using PFSC.Models.Home;

namespace PFSC.Services.Abstract.Factory
{
    public interface IFactoryService
    {
        IEnumerable<TopRatedFactoryInfo> GetTopRated();
        FactoryModel GetFullFactoryInfo(int factoryId);
        List<ReviewModel> GetReviews(Func<Review, bool> predicate = null);
        List<NotificationModel> GetNotifications(Func<FactoryAdminNotification, bool> predicate = null);
        List<OrderModel> GetOrders(Func<Order, bool> predicate = null);
        List<MachineModel> GetMachines(Func<Machine, bool> predicate = null);
    }
}
