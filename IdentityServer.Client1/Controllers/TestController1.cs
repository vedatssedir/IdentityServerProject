using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Client1.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
