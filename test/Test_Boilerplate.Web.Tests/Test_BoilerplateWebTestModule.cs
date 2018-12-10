using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Test_Boilerplate.Web.Startup;
namespace Test_Boilerplate.Web.Tests
{
    [DependsOn(
        typeof(Test_BoilerplateWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class Test_BoilerplateWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test_BoilerplateWebTestModule).GetAssembly());
        }
    }
}