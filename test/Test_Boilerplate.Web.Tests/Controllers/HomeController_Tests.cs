using System.Threading.Tasks;
using Test_Boilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace Test_Boilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: Test_BoilerplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
