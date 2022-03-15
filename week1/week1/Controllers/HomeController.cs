using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using week1.Models;

namespace week1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Customer()
        {

            //create new list
            var model = new List<Customer>
            {
                new Customer{
                Age = 21,
                Name = "Aizat",
                Surname = "Esenbekova",
                Address = "Konya"
                },

                new Customer{
                Age = 22,
                Name = "MK",
                Surname = "Omurbekov",
                Address = "Istanbul"
                },

                new Customer{
                Age = 23,
                Name = "Anisa",
                Surname = "Bopunova",
                Address = "Samsun"
                },

                new Customer{
                Age = 32,
                Name = "David",
                Surname = "Malana",
                Address = "New York"
                }

            };
            return View(model);
        }
        public IActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Student(Student student)
        {
            if (ModelState.IsValid)
            {
                return View();
                //return RedirectToAction("Error", ModelState); // error sayfasına yönlendir !tavsiye edilmiyor
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //status codes
        public IActionResult BadReq()
        {
            return BadRequest("Hata:yetkisiz giriş");//aynı zamanda içerisini boş da dönebiliriz
        }
        public IActionResult SucReq()
        {
            //farklı propertileri alan aynı isimli methodlara overload denir
            return Ok(new SuccessViewModel { StatusCode = 200, Message = "İşlem başarılı" });
        }
        public IActionResult PageNotFound()
        {
            return NotFound();
        }
        public IActionResult ForbiddenPage()
        {
            return StatusCode(StatusCodes.Status403Forbidden);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
