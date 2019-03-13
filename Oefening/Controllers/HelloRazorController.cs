using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oefening.Controllers
{
    public class HelloRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}