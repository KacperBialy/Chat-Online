using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Online.Controllers
{
    public class LogginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
