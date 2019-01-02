using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.EntityFrameworkCore
{
    public class Test_BoilerplateDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
      public virtual DbSet<Person> Person { get; set; }
      public virtual DbSet<Item> Item { get; set; }

      public Test_BoilerplateDbContext(DbContextOptions<Test_BoilerplateDbContext> options) 
            : base(options)
        {

        }
    }
}
