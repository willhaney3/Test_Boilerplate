using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.DAL
{
  public class PersonManager: Abp.Domain.Services.DomainService, IPersonManager
  {

    private readonly AbpRepositoryBase<Person, long> _personRepository;

    public PersonManager(AbpRepositoryBase<Person,long> personRepository)
    {
      _personRepository = personRepository;
    }

    public async Task Person_Insert(string PersonName)
    {
      await _personRepository.InsertAsync(new Person() {PersonName = PersonName});
    }

    public async Task<Person> GetPersonById(long Id)
    {
      return await _personRepository.GetAsync(Id);
    }
  }
}
