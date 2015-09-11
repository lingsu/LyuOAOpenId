using System.Security.Claims;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Zero.Authorization.Users;
using Abp.Zero.Identity;

namespace Lyu.Core.Domin.Users
{
    public class UserManager : AbpUserManager
    {
        private readonly IRepository<HrInfo> _hrinfoRepository;

        public UserManager(UserStore store, IPermissionManager permissionManager, IUnitOfWorkManager unitOfWorkManager, IRepository<HrInfo> hrinfoRepository) : base(store, permissionManager, unitOfWorkManager)
        {
            _hrinfoRepository = hrinfoRepository;
        }

        public async override Task<ClaimsIdentity> CreateIdentityAsync(AbpUser user, string authenticationType)
        {
            var identity = await base.CreateIdentityAsync(user, authenticationType);
            identity.AddClaim(new Claim(LyuClaimTypes.UserHrid, user.Hrid.ToString()));

            var hr = _hrinfoRepository.FirstOrDefault(user.Hrid);
            identity.AddClaim(new Claim(LyuClaimTypes.Companyid, hr.HrDepartment.CompanyId.ToString()));

            return identity;
        }
    }
}