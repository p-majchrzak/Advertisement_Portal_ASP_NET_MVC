using Microsoft.AspNetCore.Mvc;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
