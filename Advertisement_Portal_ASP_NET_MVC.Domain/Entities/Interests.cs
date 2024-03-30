﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class Interests
    {
        public required int ID { get; set; }
        public string Content { get; set; } = default!;
        public UserData User { get; set; } = default!;
    }
}
