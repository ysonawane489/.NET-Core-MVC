using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult S()
        {
            return View();
        }
        public IActionResult ViewBagSingleValue()
        {
            ViewBag.Name = "Yogesh";
            return View();
        }
       
    }
}
