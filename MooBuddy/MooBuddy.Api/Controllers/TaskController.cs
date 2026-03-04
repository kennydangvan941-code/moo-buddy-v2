using Microsoft.AspNetCore.Mvc;

namespace MooBuddy.Api.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
