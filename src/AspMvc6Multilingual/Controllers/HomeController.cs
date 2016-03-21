using System;
using AspMvcMultilingual.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AspMvcMultilingual.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var home = new Home {Money = (new Random().Next(1, 100000))/10.0};
            return View(home);
        }
    }
}
