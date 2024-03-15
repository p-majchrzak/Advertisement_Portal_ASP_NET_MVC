using Advertisement_Portal_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class FirmLoggedController : Controller
    {
        private readonly ILogger<FirmLoggedController> _logger;
        public FirmLoggedController(ILogger<FirmLoggedController> logger)
        {
            _logger = logger;
        }
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        public IActionResult Applications()
        {
            return View();
        }
        public IActionResult ApplicationsHistory()
        {
            return View();
        }
        public IActionResult CandidateProfile()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult ManageAccount()
        {
            return View();
        }
        public IActionResult ModifyAdvertisement()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult FirmProfile()
        {
            return View();
        }
        public IActionResult ViewAdvertisements()
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
