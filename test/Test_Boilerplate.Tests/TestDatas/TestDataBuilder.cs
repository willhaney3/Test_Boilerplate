using Test_Boilerplate.EntityFrameworkCore;

namespace Test_Boilerplate.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly Test_BoilerplateDbContext _context;

        public TestDataBuilder(Test_BoilerplateDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}