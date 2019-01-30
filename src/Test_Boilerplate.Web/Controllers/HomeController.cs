using System.Threading.Tasks;
using log4net.Appender;
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

      //var personDto = await _PersonAppService.GetPersonByIdAsync(1);

      var personDtos = await _PersonAppService.GetPersonsLikeAsync("");


      return View(personDtos);
    }

    [HttpPost]
    public async Task<ActionResult> Test()
    {
      await Task.Run(() => 0);
      // return results
      return View(null);
    }


    
//    public async Task<ActionResult> AddRecord()
//    {
////      await _PersonAppService.Person_InsertAsync(personName);

//      //var personDto = await _PersonAppService.GetPersonByIdAsync(1);

//      var t = await _PersonAppService.GetPersonsLikeAsync("");

//      return View("Index",t);
//    }

    public async Task<ActionResult> About()
    {
      //var personDto = await _PersonAppService.GetPersonByIdAsync(1);

      var t = await _PersonAppService.GetPersonsLikeAsync("");

      return View(t);

      //return View(personDto);
    }
  }
}