﻿using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
