using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Models.Factory
{
    public class NotificationModel
    {
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public bool IsChecked { get; set; }
        public string NotificationType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
