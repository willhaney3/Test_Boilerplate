using Abp.Application.Services;

namespace Test_Boilerplate
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Test_BoilerplateAppServiceBase : ApplicationService
    {
        protected Test_BoilerplateAppServiceBase()
        {
            LocalizationSourceName = Test_BoilerplateConsts.LocalizationSourceName;
        }
    }
}