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

    public async Task<ActionResult> Index()
    {
      await _PersonAppService.Person_InsertAsync("Test New Ioc");

      return View();
    }

    public async Task<ActionResult> About()
    {
      var personDto = await _PersonAppService.GetPersonByIdAsync(1);

      return View(personDto);
    }
  }
}