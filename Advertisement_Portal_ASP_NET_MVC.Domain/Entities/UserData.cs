using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class UserData
    {
        public required int ID { get; set; }
        public string Photo { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Descripotion { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public UserData User { get; set; } = default!;

    }
}
