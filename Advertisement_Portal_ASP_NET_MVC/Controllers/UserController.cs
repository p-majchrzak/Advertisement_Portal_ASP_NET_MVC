using Microsoft.AspNetCore.Mvc;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
