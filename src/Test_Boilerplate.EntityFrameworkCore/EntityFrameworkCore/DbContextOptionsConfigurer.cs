using Microsoft.EntityFrameworkCore;

namespace Test_Boilerplate.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<Test_BoilerplateDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for Test_BoilerplateDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
