using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class NotificationType
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<FactoryAdminNotification> FactoryAdminNotifications { get; set; }

        public NotificationType()
        {
            FactoryAdminNotifications = new List<FactoryAdminNotification>();
        }
    }
}
