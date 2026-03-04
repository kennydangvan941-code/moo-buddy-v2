using Microsoft.AspNetCore.Mvc;

namespace MooBuddy.Api.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
