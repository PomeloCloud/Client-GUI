﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pomelo.Cloud.Client.Gui.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}
