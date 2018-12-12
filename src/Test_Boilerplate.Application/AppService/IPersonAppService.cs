using System.Threading.Tasks;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.AppService
{
  public interface IPersonAppService
  {
    Task Person_InsertAsync(string lastName);

    Task<PersonDto> GetPersonByIdAsync(long Id);
  }
}
