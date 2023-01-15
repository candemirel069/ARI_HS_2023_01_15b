using CoreWeb.Code;
using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMyWriter _writer;

        public HomeController(ILogger<HomeController> logger, IMyWriter writer)
        {
            _logger = logger;
            _writer = writer;
        }

        public IActionResult Index()
        {
            Thread.Sleep(100);
            _writer.ToConsole("Index");
            return View();
        }

        public IActionResult Privacy()
        {
            _writer.ToConsole("Privacy");
            Thread.Sleep(200);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
