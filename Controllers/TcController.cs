using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreApp.Controllers
{
    public class TcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TcVar()
        {
            return View();
        }
    }
}
