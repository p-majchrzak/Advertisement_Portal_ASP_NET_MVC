using Advertisement_Portal_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Advertisement_Portal_ASP_NET_MVC.Controllers
{
    public class UserLoggedController : Controller
    {
        private readonly ILogger<UserLoggedController> _logger;
        public UserLoggedController(ILogger<UserLoggedController> logger)
        {
            _logger = logger;
        }
        public IActionResult AccountManagement()
        {
            return View();
        }
        public IActionResult AnnouncementView()
        {
            return View();
        }
        public IActionResult FirmProfile()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult MyApplications()
        {
            return View();
        }
        public IActionResult MyProfile()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult SavedAnnouncement()
        {
            return View();
        }
        public IActionResult SearchAnnouncement()
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
