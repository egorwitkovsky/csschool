using Microsoft.AspNetCore.Mvc;

namespace CSS3School.Front.V1.Controllers
{
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Hello()
        {
            return View();
        }
    }
}
