﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Test_Boilerplate.Model;
 

namespace Test_Boilerplate.DAL
{
  public class PersonManager: DomainService, IPersonManager
  {

    private readonly IRepository<Person,long> _personRepository;

    public PersonManager(IRepository<Person,long> personRepository)
    {
      _personRepository = personRepository;
    }

    public async Task Person_InsertAsync(string personName)
    {
      await _personRepository.InsertAsync(new Person() {PersonName = personName});
    }

    public async Task<Person> GetPersonByIdAsync(long id)
    {
      return await _personRepository.GetAsync(id);
    }

    public async Task<IQueryable<Person>> GetPersonsLikeAsync(string personName)
    {
      var x = _personRepository.GetAll().Where(v => v.PersonName.Contains(personName));

      return await Task.Run(() => x);
    }
  }
}
