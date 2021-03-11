using Microsoft.AspNetCore.Mvc;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        public ApiController()
        {
            // the constuctor

        }
        [HttpGet]
        public IActionResult Test()
        {
            string name = "Trae";
            return Json(name);
        }

        [HttpGet]
        public IActionResult GetTask()
        {
            return Json(null);
        }

        [HttpPost]
        public IActionResult PostTask()
        {
            return Json(null);
        }
    }
}
