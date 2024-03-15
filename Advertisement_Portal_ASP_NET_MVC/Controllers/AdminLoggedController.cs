using Advertisement_Portal_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class AdminLoggedController : Controller
    {
        private readonly ILogger<AdminLoggedController> _logger;
        public AdminLoggedController(ILogger<AdminLoggedController> logger)
        {
            _logger = logger;
        }
        public IActionResult AdminAccounts()
        {
            return View();
        }
        public IActionResult Categories()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult SendNotification()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
