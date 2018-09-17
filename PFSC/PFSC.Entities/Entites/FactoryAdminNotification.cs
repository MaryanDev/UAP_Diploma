using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class FactoryAdminNotification
    {
        [Key]
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public int FactoryId { get; set; }
        public bool IsChecked { get; set; }
        public int NotificationTypeId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
        [ForeignKey(nameof(NotificationTypeId))]
        public NotificationType NotificationType { get; set; }
    }
}
