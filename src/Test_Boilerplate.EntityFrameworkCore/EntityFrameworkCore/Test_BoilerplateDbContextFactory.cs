using Test_Boilerplate.Configuration;
using Test_Boilerplate.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Test_Boilerplate.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class Test_BoilerplateDbContextFactory : IDesignTimeDbContextFactory<Test_BoilerplateDbContext>
    {
        public Test_BoilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Test_BoilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(Test_BoilerplateConsts.ConnectionStringName)
            );

            return new Test_BoilerplateDbContext(builder.Options);
        }
    }
}