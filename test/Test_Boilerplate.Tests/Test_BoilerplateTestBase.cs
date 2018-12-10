using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Test_Boilerplate.EntityFrameworkCore;
using Test_Boilerplate.Tests.TestDatas;

namespace Test_Boilerplate.Tests
{
    public class Test_BoilerplateTestBase : AbpIntegratedTestBase<Test_BoilerplateTestModule>
    {
        public Test_BoilerplateTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<Test_BoilerplateDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<Test_BoilerplateDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<Test_BoilerplateDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Test_BoilerplateDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<Test_BoilerplateDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<Test_BoilerplateDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<Test_BoilerplateDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Test_BoilerplateDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
