using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Test_Boilerplate.BO;
using Test_Boilerplate.DAL;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.AppService
{
  public class PersonAppService:DomainService,IPersonAppService
  {
    private readonly IPersonManager _personManager;

    public PersonAppService(IPersonManager personManager)
    {
      _personManager = personManager;
    }

    public async Task Person_Insert(string PersonName)
    {
      await _personManager.Person_Insert(PersonName);
    }

    public async Task<Person> GetPersonById(long Id)
    {
      return await _personManager.GetPersonById(Id);
    }


  }
}
