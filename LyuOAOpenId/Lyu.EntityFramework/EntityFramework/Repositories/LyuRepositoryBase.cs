using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lyu.EntityFramework.EntityFramework.Repositories
{
  
    public abstract class LyuRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LyuDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LyuRepositoryBase(IDbContextProvider<LyuDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LyuRepositoryBase<TEntity> : LyuRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LyuRepositoryBase(IDbContextProvider<LyuDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}