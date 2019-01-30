using System.Linq;
using System.Threading.Tasks;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.DAL
{
  public interface IPersonManager 
  {
    Task Person_InsertAsync(string personName);
    Task<Person> GetPersonByIdAsync(long id);
    Task<IQueryable<Person>> GetPersonsLikeAsync(string personName);

  }
}
