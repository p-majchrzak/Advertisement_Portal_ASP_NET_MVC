using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class Experience
    {
        public required int ID { get; set; }
        public string Work_Name { get; set; } = default!;
        public string Position { get; set; } = default!;
        public string Firm { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public string Description { get; set; } = default!;
        public UserData User { get; set; } = default!;
    }
}
