using System.Linq;
using System.Threading.Tasks;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.DAL
{
  public interface IPersonManager 
  {
    Task Person_InsertAsync(string PersonName);
    Task<Person> GetPersonByIdAsync(long Id);
    Task<IQueryable<Person>> GetPersonsLikeAsync(string personName);

  }
}
