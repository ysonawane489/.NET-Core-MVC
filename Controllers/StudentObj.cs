using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentObj : Controller
    {
        public IActionResult ViewBagObj()
        {
            Student st = new Student();
            st.Name = "Sagar";
            st.Age = 56;
            st.Gender = "male";

            ViewBag.StudentObject = st;

            return View();
        }
    }
}
