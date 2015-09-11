using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Modules;
using Lyu.EntityFramework;

namespace LyuOAOpenId
{
    [DependsOn(typeof(LyuDataModule))]
    public class LyuOAOpenModule: AbpModule
    {
        public override void PreInitialize()
        {
          
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}