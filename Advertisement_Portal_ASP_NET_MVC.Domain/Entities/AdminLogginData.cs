using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class AdminLogginData
    {
        public required int ID { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
