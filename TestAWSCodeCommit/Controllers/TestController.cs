using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestAWSCodeCommit.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GitView()
        {
            ViewBag.Msg = Accion();
            return View();
        }

        public string Accion()
        {
            return "Primeros Pasos en Git";
        }
    }
}