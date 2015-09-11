
namespace Lyu.Core.Domin.Users
{
    public class NiboUserSuperior:UserSuperior
    {
        public NiboUserSuperior(string office2, int? zhuguan, int? jinLi, int? zongJian, int? zuiGao) : base(office2, zhuguan, jinLi, zongJian, zuiGao)
        {
        }

        protected override int Level()
        {
            switch (Office2)
            {
                case HrOffice.P1:
                    return 0;
                case HrOffice.P2:
                case HrOffice.P3:
                    return 1;
                case HrOffice.P4:
                case HrOffice.P5:
                    return 2;
                default:
                    return 3;
            }
        }
    }
}