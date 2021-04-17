using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProje1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspProje1.Controllers
{
    public class HomeController : Controller
    {
        //ysk.com.tr/Home/Index
        public IActionResult Index()
        {
            //viewbag,viewdata,tempdata,model
            ViewBag.Name = "Yavuz";
            ViewData["Name"] = "Selim";
            TempData["Name"] = "Kahraman";


            Customer customer = new () { Age = 27, FirstName = "fatih kurt", LastName = "KURT" };
            return View(customer);
        }

        public IActionResult Yavuz()
        {

            return View();
        }

    }
}
