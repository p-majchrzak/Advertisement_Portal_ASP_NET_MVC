using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class ReportedAccount
    {
        public required int ID { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public UserData User { get; set; } = default!;
    }
}
