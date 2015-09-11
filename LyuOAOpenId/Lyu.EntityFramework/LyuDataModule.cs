using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Lyu.EntityFramework.EntityFramework;

namespace Lyu.EntityFramework
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule))]
    public class LyuDataModule: AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "shenpi";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<LyuDbContext>(null);
        }
    }
}