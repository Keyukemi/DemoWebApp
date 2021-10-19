using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoWebApp.Models;

namespace DemoWebApp.Controllers
{
    public class ArithimeticController : Controller
    {
        public IActionResult Quadratic()
        {
            return View();
        }
    }
}