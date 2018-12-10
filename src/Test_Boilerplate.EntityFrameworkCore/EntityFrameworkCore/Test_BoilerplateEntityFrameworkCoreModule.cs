using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Test_Boilerplate.EntityFrameworkCore
{
    [DependsOn(
        typeof(Test_BoilerplateCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class Test_BoilerplateEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test_BoilerplateEntityFrameworkCoreModule).GetAssembly());
        }
    }
}