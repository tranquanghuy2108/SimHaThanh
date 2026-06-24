using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class NotificationViewModel
    {
        public int? Id { get; set; }
        public int Stt { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? CollaboratorsGroup { get; set; }
    }
    public class NotificationModel
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public int? CollaboratorsGroupId { get; set; }
        public bool? IsRead { get; set; }
    }
    public class ReadNotification
    {
        public List<int> Ids { get; set; }
        public Guid userId { get; set; }
    }
}
