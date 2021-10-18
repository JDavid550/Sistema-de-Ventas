using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
    }
}
