using System.Data.Entity.Migrations;
using Lyu.EntityFramework.EntityFramework;

namespace Lyu.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LyuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LyuOA";
        }

        protected override void Seed(LyuDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}