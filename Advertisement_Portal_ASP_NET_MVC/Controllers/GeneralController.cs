using Advertisement_Portal_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class GeneralController : Controller
    {
        private readonly ILogger<GeneralController> _logger;
        public GeneralController(ILogger<GeneralController> logger)
        {
            _logger = logger;
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult CompanyData()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Download()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
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
