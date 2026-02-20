using CV.Models;
using CV.Models;
using CV.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        // ASP.NET Core injects CvDataService here via the constructor.
        private readonly CvDataService _cvDataService;

        public HomeController(CvDataService cvDataService)
        {
            _cvDataService = cvDataService;
        }

        public IActionResult Index()
        {
            // Load the full CV data and pass it to the view as the Model
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/Index.cshtml
        }

        // GET: /Home/About
        public IActionResult About()
        {
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/About.cshtml
        }

        // GET: /Home/Skills
        public IActionResult Skills()
        {
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/Skills.cshtml
        }

        // GET: /Home/Projects
        public IActionResult Projects()
        {
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/Projects.cshtml
        }

        // GET: /Home/Education
        public IActionResult Education()
        {
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/Education.cshtml
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            var model = _cvDataService.GetCvData();
            return View(model);  // Renders Views/Home/Contact.cshtml
        }

        // GET: /Home/Error  — Required for the exception handler middleware
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}