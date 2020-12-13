using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyInsurance.Domain.Services;
using MyInsurance.WebApplication.Models;
using System.Diagnostics;

namespace MyInsurance.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOficinaService _oficinaService;

        public HomeController(ILogger<HomeController> logger,
            IOficinaService oficinaService)
        {
            _logger = logger;
            _oficinaService = oficinaService;
        }

        public IActionResult Index()
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
