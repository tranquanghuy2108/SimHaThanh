using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EFCoreMySQL.EntityModels
{
    public class NotificationUser:EntityCommon
    {
        [DefaultValue(false)]
        public bool IsRead { get; set; }
        public int NotificationId { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey("NotificationId")]
        public virtual Notification? Notification { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser? User { get; set; }
    }
}
