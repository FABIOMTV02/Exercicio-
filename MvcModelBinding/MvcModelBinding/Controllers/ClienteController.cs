﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcModelBinding.Controllers
{
    public class ClienteController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}
