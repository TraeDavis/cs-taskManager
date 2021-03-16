using Microsoft.AspNetCore.Mvc;
using taskManager.Models;
using System.Linq;
using System.Collections.Generic;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        private DataContext DbContext;

        public ApiController(DataContext db)
        {
            // the constuctor
            DbContext = db;

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
            // read the database
            var tasks = DbContext.Tasks.ToList();

            return Json(tasks);
        }

        [HttpPost]
        public IActionResult PostTask([FromBody] Task theTask)
        {
            //  send theTask to database
            DbContext.Tasks.Add(theTask);
            DbContext.SaveChanges();

            // return the object
            return Json(theTask);
        }
    }
}
