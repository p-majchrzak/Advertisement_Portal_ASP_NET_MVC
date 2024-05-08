using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Domain.Interfaces
{
    public interface IMenageObjectRepository
    {
        Task Create(object newObject);
    }
}
