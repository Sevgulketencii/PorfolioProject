using Microsoft.AspNetCore.Mvc;
using PorfolioProject.Models;
using System.Diagnostics;

namespace PorfolioProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}