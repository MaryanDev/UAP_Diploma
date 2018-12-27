using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Entities.Entites;
using PFSC.Models.Enums;
using PFSC.Models.Factory;
using PFSC.Models.User;

namespace PFSC.Services.Mappings
{
    public static class PfscMappings
    {
        public static MachineModel MachineEntityToModel(Machine machine)
        {
            return new MachineModel
            {
                Id = machine.Id,
                Description = machine.Description,
                Manufacturer = machine.Manufacturer.Title,
                Title = machine.Title
            };
        }

        public static NotificationModel NotificationEntityToModel(FactoryAdminNotification notification)
        {
            return new NotificationModel
            {
                Id = notification.Id,
                CreatedDate = notification.CreatedDate,
                IsChecked = notification.IsChecked,
                NotificationText = notification.NotificationText,
                NotificationType = notification.NotificationType.Title
            };
        }

        public static OrderModel OrderEntityToModel(Order order)
        {
            return new OrderModel
            {
                Id = order.Id,
                CreatedDate = order.CreatedDate,
                Description = order.Description,
                CompletedDate = order.CompletedDate,
                CustomerName = order.CustomerName,
                CustormerPhone = order.CustormerPhone,
                IsCompleted = order.IsCompleted,
                OrderState = order.OrderState.Status,
                OrderValue = order.OrderValue.Value,
                Price = order.Price

            };
        }

        public static ReviewModel ReviewEntityToModel(Review review)
        {
            return new ReviewModel
            {
                Id = review.Id,
                Title = review.Title,
                DateCreated = review.DateCreated,
                ReviewResultDescription = review.ReviewResult.Description,
                ReviewResultTitle = review.ReviewResult.Title,
                Text = review.Text
            };
        }

        public static EmployeeModel EmployeeEntityToModel(Employee employee)
        {
            return new EmployeeModel()
            {
                Id = employee.Id,
                AvatarPath = employee.AvatarPath,
                Name = employee.FirstName + " " + employee.LastName,
                Position = employee.Position.Description,
                Salary = employee.Salary
            };
        }

        public static UserModel UserToUserModel(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                AvatarPath = user.AvatarPath,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Role = (PfscRoles)user.RoleId  ,
                Password = user.Password
            };
        }
    }
}
