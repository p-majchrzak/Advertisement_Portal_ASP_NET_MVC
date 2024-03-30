using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class AnnouncementSkills
    {
        public required int ID { get; set; }
        public Skills Skill { get; set; } = default!;
        public Announcement Announcement { get; set; } = default!;  
    }
}
