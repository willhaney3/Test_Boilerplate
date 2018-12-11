using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Boilerplate.AppService;

namespace Test_Boilerplate.Web.Controllers
{
  public class HomeController : Test_BoilerplateControllerBase
  {

    private readonly IPersonAppService _PersonAppService;

    public HomeController(IPersonAppService personAppService)
    {
      _PersonAppService = personAppService;
    }

    public ActionResult Index()
    {
      _PersonAppService.Person_Insert("Test New Ioc");

      return View();
    }

    public ActionResult About()
    {
      return View();
    }
  }
}