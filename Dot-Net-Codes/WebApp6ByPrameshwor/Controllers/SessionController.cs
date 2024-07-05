﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByPrameshwor.Controllers

{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("uname", "Prameshwor");
            HttpContext.Session.SetString("pw", "12345");
            return View();
        }
        public IActionResult SessionPage()
        {
            string uname = HttpContext.Session.GetString("uname").ToString();
            string pw = HttpContext.Session.GetString("pw").ToString();
            ViewBag.username = uname;
            ViewBag.password = pw;
            return View();
        }
    }
}
