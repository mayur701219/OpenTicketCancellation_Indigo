using Microsoft.AspNetCore.Mvc;
using OpenTicketCancellationWeb.Models;
using System.Diagnostics;

namespace OpenTicketCancellationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TimedHostedService _timedHostedService;

        public HomeController(ILogger<HomeController> logger, TimedHostedService timedHostedService)
        {
            _logger = logger;
            _timedHostedService = timedHostedService;
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

        //[HttpPost]
        //public IActionResult RunConsoleApp()
        //{
        //    var output = new System.Text.StringBuilder();

        //    // Capture the console output
        //    using (var writer = new System.IO.StringWriter(output))
        //    {
        //        Console.SetOut(writer);
        //        _timedHostedService.DoWork(null);
        //        Console.SetOut(System.Console.Out); // Reset the console output
        //    }

        //    ViewBag.Output = output.ToString();

        //    return View("RunConsoleAppResult");
        //}


        [HttpPost]
        public async Task<IActionResult> StartHostedService()
        {
            await _timedHostedService.ManualStartAsync(CancellationToken.None);
            TempData["Message"] = "Hosted Service Started";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> StopHostedService()
        {
            await _timedHostedService.ManualStopAsync(CancellationToken.None);
            TempData["Message"] = "Hosted Service Stopped";
            return RedirectToAction("Index");
        }
    }
}