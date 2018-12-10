using Abp.AspNetCore.Mvc.Controllers;

namespace Test_Boilerplate.Web.Controllers
{
    public abstract class Test_BoilerplateControllerBase: AbpController
    {
        protected Test_BoilerplateControllerBase()
        {
            LocalizationSourceName = Test_BoilerplateConsts.LocalizationSourceName;
        }
    }
}