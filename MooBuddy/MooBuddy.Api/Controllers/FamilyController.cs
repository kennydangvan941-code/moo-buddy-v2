using Microsoft.AspNetCore.Mvc;

namespace MooBuddy.Api.Controllers
{
    public class FamilyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
