using DotNet_Lab4.Data;
using DotNet_Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNet_Lab4.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly DotNet_Lab4Context _context;
        public HomeController(ILogger<HomeController> logger, DotNet_Lab4Context context)
		{
			_logger = logger;
            _context = context;
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

   

        

        public IActionResult PaymentsCust(DateTime date)
        {
            List<Payment> payments = _context.Payment.Where(p => p.PaymentType.Date == date.Date).ToList();
            ViewBag.Date = date.ToShortDateString();
            return View(payments);
        }


    }
}