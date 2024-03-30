using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class Message
    {
        public required int ID { get; set; }
        public string Email { get; set; } = default!;
        public string Content { get; set; } = default!; 
    }
}
