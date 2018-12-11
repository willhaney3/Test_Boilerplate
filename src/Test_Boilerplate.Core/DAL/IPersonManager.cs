using System.Threading.Tasks;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.DAL
{
  public interface IPersonManager 
  {
    Task Person_Insert(string PersonName);
    Task<Person> GetPersonById(long Id);

  }
}
