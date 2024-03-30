using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class ApplicationsHistory
    {
        public required int ID { get; set; }
        public UserData User { get; set; } = default!;
        public Announcement Announcement { get; set; } = default!;
        public FirmData Firm { get; set; } = default!;
    }
}
