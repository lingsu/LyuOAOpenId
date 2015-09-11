using System.Reflection;
using Abp.Modules;
using Abp.Zero;

namespace Lyu.Core
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class LyuCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}