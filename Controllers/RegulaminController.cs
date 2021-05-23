using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CoreWebApplicationPage.Controllers
{
    public class RegulaminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
