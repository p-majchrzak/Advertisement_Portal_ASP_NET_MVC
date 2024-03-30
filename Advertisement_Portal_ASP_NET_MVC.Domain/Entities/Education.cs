using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class Education
    {
        public required int ID { get; set; }
        public string School_Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public DateTime Start { get; set; } = default!;
        public DateTime End { get; set; } = default!;
        public string Description { get; set; } = default!;
        public UserData User { get; set; } = default!;

    }
}
