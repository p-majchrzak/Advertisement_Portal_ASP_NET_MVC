using Advertisement_Portal_ASP_NET_MVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Application.Services
{
    public class MenageObjectService : IMenageObjectService
    {
        private readonly IMenageObjectRepository _repository;
        public MenageObjectService(IMenageObjectRepository repository)
        {
            _repository = repository;
        }
        public async Task Create(object newObject)
        {

            await _repository.Create(newObject);
        }
    }
}
