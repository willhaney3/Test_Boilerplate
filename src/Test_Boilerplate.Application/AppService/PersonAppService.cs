using System.Threading.Tasks;
using Abp.Application.Services;
using Test_Boilerplate.DAL;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.AppService
{
  public class PersonAppService: ApplicationService,  IPersonAppService
  {
    private readonly IPersonManager _personManager;

    public PersonAppService(IPersonManager personManager)
    {
      _personManager = personManager;
    }

    public async Task Person_InsertAsync( string lastName)
    {
     await _personManager.Person_InsertAsync(lastName);
    }

    public async Task<Person> GetPersonByIdAsync(long Id)
    {
      return await _personManager.GetPersonByIdAsync(Id);
    }

  }
}
