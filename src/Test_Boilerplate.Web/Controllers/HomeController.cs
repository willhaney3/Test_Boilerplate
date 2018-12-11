using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Boilerplate.BO;

namespace Test_Boilerplate.Web.Controllers
{
    public class HomeController : Test_BoilerplateControllerBase
    {

      private readonly IPersonAppService _personAppService;

      public HomeController(IPersonAppService personAppService)
      {
        _personAppService = personAppService;
      }

        public async Task<ActionResult> Index()
        {

          await _personAppService.Person_Insert("Test person");

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}