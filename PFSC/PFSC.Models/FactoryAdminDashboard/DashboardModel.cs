using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.Factory;
using PFSC.Models.User;

namespace PFSC.Models.FactoryAdminDashboard
{
    public class DashboardModel
    {
        public string FactoryName { get;set; }
        public UserModel DashboardUser { get; set; }                            
        public List<EmployeeModel> Employees { get; set; }
        public List<MachineModel> PrintingMachines { get; set; }
        public List<ReviewModel> Reviews { get; set; }
        public List<OrderModel> Orders { get; set; }                          
        public List<NotificationModel> Notifications { get; set; }
        public List<string> FactoryPhotos { get; set; }
    }
}
