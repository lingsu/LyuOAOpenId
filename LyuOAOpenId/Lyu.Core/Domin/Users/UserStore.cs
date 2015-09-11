using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using Abp.Zero.Authorization.Users;

namespace Lyu.Core.Domin.Users
{
    public class UserStore : AbpUserStore
    {
        public UserStore(IRepository<AbpUser> userRepository,/* IRepository<UserRole> userRoleRepository, IRepository<AbpRole> roleRepository,*/ IAbpSession session, IUnitOfWorkManager unitOfWorkManager) : base(userRepository, null, null, session, unitOfWorkManager)
        {
        }
    }
}