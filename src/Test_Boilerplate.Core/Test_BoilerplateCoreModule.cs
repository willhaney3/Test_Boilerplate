using Abp.Modules;
using Abp.Reflection.Extensions;
using Test_Boilerplate.Localization;

namespace Test_Boilerplate
{
    public class Test_BoilerplateCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            Test_BoilerplateLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test_BoilerplateCoreModule).GetAssembly());
        }
    }
}