﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class BaseAdminController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
    }
}
