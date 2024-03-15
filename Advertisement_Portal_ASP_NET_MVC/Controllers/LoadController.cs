using Advertisement_Portal_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class LoadController : Controller
    {
        private readonly ILogger<LoadController> _logger;
        public LoadController(ILogger<LoadController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
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
