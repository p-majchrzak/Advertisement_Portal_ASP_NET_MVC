using Advertisement_Portal_ASP_NET_MVC.Application.Services;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class MenageObjectController : Controller
    {
        private readonly IMenageObjectService _service;
        public MenageObjectController(IMenageObjectService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(object newObject)
        {
           await _service.Create(newObject);
            return RedirectToAction(nameof(Create)); //to do
        }
    }
}
