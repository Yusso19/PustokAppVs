using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PustokApp.Models;

namespace PustokApp.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
