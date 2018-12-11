using System.Threading.Tasks;
using Abp.Domain.Services;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.DAL
{
  public interface IPersonManager : IDomainService
  {
    Task Person_Insert(string PersonName);
    Task<Person> GetPersonById(long Id);

  }
}
