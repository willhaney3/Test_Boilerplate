using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Boilerplate.AppService;

namespace Test_Boilerplate.Web.Controllers
{

  public class TestController : Test_BoilerplateControllerBase
  {
    private readonly IPersonAppService _personAppService;

    public TestController(IPersonAppService personAppService)
    {
      _personAppService = personAppService;
    }

    public ActionResult Index()
    {

      //var personDto = await _PersonAppService.GetPersonByIdAsync(1);

      //var t = await _personAppService.GetPersonsLikeAsync("");

	    //await Task.Run(() => 0);

      return View(null);
    }

    [HttpPost]
    [IgnoreAntiforgeryToken]
    public async Task<ActionResult> Index2(PersonDto personDto)
    {
      await _personAppService.Person_InsertAsync(personDto.PersonName);

      return RedirectToAction("Index", "Home");
      
    }


  }
}
