using Microsoft.AspNetCore.Mvc;

namespace MooBuddy.Api.Controllers
{
    public class FarmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
