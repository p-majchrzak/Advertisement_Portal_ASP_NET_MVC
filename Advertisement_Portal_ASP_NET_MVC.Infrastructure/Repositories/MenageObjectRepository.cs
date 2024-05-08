using Advertisement_Portal_ASP_NET_MVC.Domain.Interfaces;
using Advertisement_Portal_ASP_NET_MVC.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Infrastructure.Repositories
{
    public class MenageObjectRepository : IMenageObjectRepository
    {
        private readonly Database db;
        public MenageObjectRepository(Database database) 
        {
            db = database;
        }

        public async Task Create(object newObject)
        {
            db.Add(newObject);
            await db.SaveChangesAsync();
        }
    }
}
