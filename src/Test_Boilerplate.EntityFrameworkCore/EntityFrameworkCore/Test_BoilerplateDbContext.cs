using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test_Boilerplate.EntityFrameworkCore
{
    public class Test_BoilerplateDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public Test_BoilerplateDbContext(DbContextOptions<Test_BoilerplateDbContext> options) 
            : base(options)
        {

        }
    }
}
