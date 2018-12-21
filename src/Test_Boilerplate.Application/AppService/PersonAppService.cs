using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.ObjectMapping;
using Test_Boilerplate.DAL;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.AppService
{
  public class PersonAppService: ApplicationService,  IPersonAppService
  {
    private readonly IPersonManager _personManager;
    private readonly IObjectMapper _objectMapper;

    public PersonAppService(IPersonManager personManager, IObjectMapper objectMapper)
    {
      _personManager = personManager;
      _objectMapper = objectMapper;
    }

    public async Task Person_InsertAsync( string lastName)
    {
     await _personManager.Person_InsertAsync(lastName);
    }

    public async Task<PersonDto> GetPersonByIdAsync(long Id)
    {
      var person = await _personManager.GetPersonByIdAsync(Id);

      var x = _objectMapper.Map<PersonDto>(person);

      return x;
    }

    public async Task<List<PersonDto>> GetPersonsLikeAsync(string personName)
    {
      var r = await _personManager.GetPersonsLikeAsync(personName);

      var x = _objectMapper.Map<List<PersonDto>>(r);

      return x;
    }

  }
}
