using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Boilerplate.AppService;

namespace Test_Boilerplate.Web.Controllers
{

  public class TestController : Test_BoilerplateControllerBase
  {
    private readonly IPersonAppService _PersonAppService;

    public TestController(IPersonAppService personAppService)
    {
      _PersonAppService = personAppService;
    }

    public async Task<ActionResult> Index()
    {

      //var personDto = await _PersonAppService.GetPersonByIdAsync(1);

      var t = await _PersonAppService.GetPersonsLikeAsync("");


      return View(null);
    }

    [HttpPost]
    [IgnoreAntiforgeryToken]
    public async Task<ActionResult> Index2(PersonDto personDto)
    {
      await _PersonAppService.Person_InsertAsync(personDto.PersonName);

      return RedirectToAction("Index", "Home");
      
    }


  }
}
