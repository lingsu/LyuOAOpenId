using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Web;
using LyuOAOpenId.Infrastructure;

namespace LyuOAOpenId
{
    public class MvcApplication : AbpWebApplication
    {
        //private static object behaviorInitializationSyncObject = new object();
        protected override void Application_Start(object sender, EventArgs e)
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            base.Application_Start(sender, e);

            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    InitializeBehaviors();
        //}
        //private static void InitializeBehaviors()
        //{
        //    if (DotNetOpenAuth.OpenId.Provider.Behaviors.PpidGeneration.PpidIdentifierProvider == null)
        //    {
        //        lock (behaviorInitializationSyncObject)
        //        {
        //            if (DotNetOpenAuth.OpenId.Provider.Behaviors.PpidGeneration.PpidIdentifierProvider == null)
        //            {
        //                DotNetOpenAuth.OpenId.Provider.Behaviors.PpidGeneration.PpidIdentifierProvider = new AnonymousIdentifierProvider();
        //                DotNetOpenAuth.OpenId.Provider.Behaviors.GsaIcamProfile.PpidIdentifierProvider = new AnonymousIdentifierProvider();
        //            }
        //        }
        //    }
        //}
    }
}
