
namespace Lyu.Core.Domin.Users
{
    public abstract class UserSuperior
    {
        protected readonly string Office2;
        protected readonly int?[] TopIds;

        protected UserSuperior(string office2, int? zhuguan, int? jinLi, int? zongJian, int? zuiGao)
        {
            Office2 = office2;
            TopIds = new[] { zhuguan, jinLi, zongJian, zuiGao };
        }

        public int? Superior()
        {
            var i = Level();
            for (; i < TopIds.Length; i++)
            {
                if (TopIds[i].HasValue && TopIds[i] > 0)
                {
                    return TopIds[i];
                }
            }

            return null;
        }

        protected virtual int Level()
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