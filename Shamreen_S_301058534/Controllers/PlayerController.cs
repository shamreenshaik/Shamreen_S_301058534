using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shamreen_S_301058534.Controllers
{
    public class PlayerController : Controller
    {
        public ViewResult ManagePlayer()
        {
            return View();
        }
        public ViewResult AddPlayer()
        {
            return View();
        }
        public ViewResult ReassignPlayer()
        {
            return View();
        }

        public ViewResult DeregisterPlayer()
        {
            return View();
        }
    }
}


