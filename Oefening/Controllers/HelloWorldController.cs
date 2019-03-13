using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Oefening.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Dit is de 'Index' Action Method";
        }

        public string Welkom()
        {
            return "Dit is de 'Welkom' Action Method";
        }
    }
}
