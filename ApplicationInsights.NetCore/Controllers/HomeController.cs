using ApplicationInsights.NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationInsights.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogTrace("Home => Index => LogLevel Trace");
            _logger.LogDebug("Home => Index => LogLevel Debug");
            _logger.LogInformation("Home => Index => LogLevel Information");                        
            _logger.LogWarning("Home => Index => LogLevel Warning");
            _logger.LogError("Home => Index => LogLevel Error");
            _logger.LogCritical("Home => Index => LogLevel Critical");            

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
