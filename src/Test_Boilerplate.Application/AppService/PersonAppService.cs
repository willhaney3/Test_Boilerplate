using Abp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using Test_Boilerplate.DAL;

namespace Test_Boilerplate.AppService
{
  public class PersonAppService: ApplicationService,  IPersonAppService
  {
    private readonly IPersonManager _personManager;

    public PersonAppService(IPersonManager personManager)
    {
      _personManager = personManager;
    }

    public async Task Person_Insert( string lastName)
    {
     await _personManager.Person_Insert(lastName);
    }


  }
}
