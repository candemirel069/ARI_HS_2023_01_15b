using CoreWeb.Code;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class YeniController : Controller
    {
        private readonly IMyWriter _writer;

        public YeniController(IMyWriter writer)
        {
            _writer = writer;
        }

        public IActionResult Index()
        {
            _writer.ToConsole("yeni:Index");
            return View();
        }
    }
}
