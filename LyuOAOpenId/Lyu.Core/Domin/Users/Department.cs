using System.Collections.Generic;
using Abp.Domain.Entities;

namespace Lyu.Core.Domin.Users
{
    public class Department:Entity
    {
        public int CompanyId { get; set; } // CompanyId
        public string HrDepartment { get; set; } // HrDepartment
        public string HrDepartment2 { get; set; } // HrDepartment2
        public string HrDepartmentCode { get; set; } // HrDepartmentCode
        public int? HrDepartmentCount { get; set; } // HrDepartmentCount
        public bool DelFlag { get; set; } // DelFlag
        public int TopId { get; set; } // TopId
        public int? TopHr { get; set; } // TopHr
        public string TopId2 { get; set; } // TopId2
        public string HrDepartmentBoss { get; set; } // HrDepartmentBoss
        public string HrDepartmentBoss2 { get; set; } // HrDepartmentBoss2
        public bool? Tj { get; set; } // Tj
        public bool? Tj2 { get; set; } // Tj2
        public string HrDepartment3 { get; set; } // HrDepartment3
        public int? SortId { get; set; } // SortId
        public string HrDepartmentC { get; set; } // HrDepartmentC
        public int? Zhuguan { get; set; } // zhuguan
        public int? JinLi { get; set; } // JinLi
        public int? ZongJian { get; set; } // ZongJian
        public int? ZuiGao { get; set; } // ZuiGao
        public int? FShangBao { get; set; } // F_shangBao
        public int? FShengHe { get; set; } // F_shengHe
        public int? CompanyDgJid { get; set; } // companyDGJid

        public virtual ICollection<HrInfo> HrInfos { get; set; } 
    }
}