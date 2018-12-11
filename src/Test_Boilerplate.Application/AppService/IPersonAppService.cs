using System.Threading.Tasks;

namespace Test_Boilerplate.AppService
{
  public interface IPersonAppService
  {
    Task Person_Insert(string lastName);
  }
}
