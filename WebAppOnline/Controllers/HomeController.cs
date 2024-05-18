using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppOnline.Models;

namespace WebAppOnline.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CheckTable()
        {
            List<TableViewModel> account = new List<TableViewModel>();
            account.Add(new TableViewModel("Anh Thư", "18", "Ninh Thuận"));
            account.Add(new TableViewModel("Văn Năm", "28", "Thái Bình"));
            account.Add(new TableViewModel("Trần Dần", "80", "Kiên Giang"));
            account.Add(new TableViewModel("An Lạc", "20", "Hồ Chí Minh"));
            return View(account);
        }
        [HttpPost]
        public IActionResult CheckTable(List<TableViewModel> table)
        {
            return View(table);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult LandingPage()
        {
            return View();
        }
    }
}