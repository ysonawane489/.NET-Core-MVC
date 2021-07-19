using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ViewData : Controller
    {
        private readonly ILogger<ViewData> _logger;

        public ViewData(ILogger<ViewData> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            List<User> list = new List<User>();
            list.Add(new User() { Id = 101, Name = "Sagar" });
            list.Add(new User() { Id = 103, Name = "Ramesh" });
            list.Add(new User() { Id = 104, Name = "Dinesh" });
            ViewData["Succefuully "]=list;
            return View();
        }

        public IActionResult Privacy()
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
