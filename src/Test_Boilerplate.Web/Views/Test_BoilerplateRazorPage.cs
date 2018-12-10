using Abp.AspNetCore.Mvc.Views;

namespace Test_Boilerplate.Web.Views
{
    public abstract class Test_BoilerplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected Test_BoilerplateRazorPage()
        {
            LocalizationSourceName = Test_BoilerplateConsts.LocalizationSourceName;
        }
    }
}
