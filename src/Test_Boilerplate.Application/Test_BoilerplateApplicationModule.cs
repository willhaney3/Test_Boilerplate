using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Test_Boilerplate
{
    [DependsOn(
        typeof(Test_BoilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Test_BoilerplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test_BoilerplateApplicationModule).GetAssembly());
        }
    }
}