using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Entities
{
    public class FirmData
    {
        public required int ID { get; set; }
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public int NIP { get; set; }
        public int REGON { get; set; }
        public string PhoneNubmer { get; set; } = default!;
        public FirmLogginData Firm { get; set; } = default!;
    }
}
