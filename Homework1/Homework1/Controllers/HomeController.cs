using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //**************************
        public IActionResult Login(UserModel model)
        {
            if(ModelState.IsValid)
            { 
                return View(model);
            }
            return View();
        }

        public IActionResult Success()
        {
            return Ok(new Response { success = true, error = null, data = "İşlem başarılı" });
        }

        public IActionResult False()
        {
            return BadRequest(new Response { success = false, error = "hata", data = "Hatalı giriş" });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
