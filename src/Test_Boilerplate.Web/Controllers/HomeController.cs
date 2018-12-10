using Microsoft.AspNetCore.Mvc;

namespace Test_Boilerplate.Web.Controllers
{
    public class HomeController : Test_BoilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}