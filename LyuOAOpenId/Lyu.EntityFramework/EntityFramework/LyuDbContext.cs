using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Abp.Zero.EntityFramework;
using Abp.Extensions;
using Lyu.Core.Domin.Users;
using Lyu.EntityFramework.Configuration;

namespace Lyu.EntityFramework.EntityFramework
{
    public class LyuDbContext : AbpZeroDbContext
    {
        public IDbSet<HrInfo> HrInfos { get; set; }
        public IDbSet<Department> Departments { get; set; }

        public LyuDbContext()
           : base("shenpi")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in LyuOADataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of LyuOADbContext since ABP automatically handles it.
         */
        public LyuDbContext(string nameOrConnectionString)
                : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !type.Namespace.IsNullOrEmpty())
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(NopEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}