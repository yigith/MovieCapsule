using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCapsule.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
