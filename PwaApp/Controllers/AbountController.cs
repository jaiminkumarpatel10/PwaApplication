using Microsoft.AspNetCore.Mvc;
using PwaApp.Models;

namespace PwaApp.Controllers
{      
    [Route("[controller]")]
    public class AbountController : Controller
    {
        [Route("[action]")]
        public string Phone()
        {
            return "+9157156699";
        }


        [Route("[action]")]
        public ViewResult Emp()
        {
            var emp = new Employee { Id = 1, Name = "df" };
            return View(emp);
        }
        /*        [Route("[action]")]
        public ObjectResult Emp()
        {
            var emp = new Employee { Id = 1, Name = "df" };
            return new ObjectResult(emp);
        }*/

    }
}
