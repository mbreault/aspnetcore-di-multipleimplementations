using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings AppSettings { get; set; }
        private IEnumerable<IHelloer> Helloers { get; set; }

        public HomeController(IEnumerable<IHelloer> helloers, IOptions<AppSettings> settings)
        {
            Helloers = helloers;
            AppSettings = settings.Value;
        }

        public IActionResult Index()
        {
            var helloer = Helloers.FirstOrDefault(h => h.CurrentName == AppSettings.CurrentHelloer);
            var message = helloer?.SayHello();
            return Content(message);
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
