using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Test_Boilerplate.Configuration;
using Test_Boilerplate.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Test_Boilerplate.Web.Startup
{
    [DependsOn(
        typeof(Test_BoilerplateApplicationModule), 
        typeof(Test_BoilerplateEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class Test_BoilerplateWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Test_BoilerplateWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(Test_BoilerplateConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<Test_BoilerplateNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(Test_BoilerplateApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test_BoilerplateWebModule).GetAssembly());
        }
    }
}