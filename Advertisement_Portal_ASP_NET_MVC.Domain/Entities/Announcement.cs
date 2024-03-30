using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class Announcement
    {
        public required int ID { get; set; }
        public string Job_Name { get; set; } = default!;
        public string Position_Level { get; set; } = default!;
        public string Contract_Type { get; set; } = default!;
        public string Working_Time { get; set; } = default!;
        public string Operating_Mode { get; set; } = default!;
        public string Work_Hours { get; set; } = default!;
        public string Duties { get; set; } = default!;
        public string Benefits { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Subcategory { get; set; } = default!;
        public DateTime Expiration_Date { get; set; } = default!;
        public string Requirements { get; set; } = default!;
        public string Remuneration { get; set; } = default!;
        public FirmData Firm { get; set; } = default!;
    }
}
