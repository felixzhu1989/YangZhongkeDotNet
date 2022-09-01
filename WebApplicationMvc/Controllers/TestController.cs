using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Demo1()
        {
            Person model = new Person("zhf3", true, DateTime.Now);
            return View(model);
        }
    }
}
