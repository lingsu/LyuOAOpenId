using System;
using Abp.Domain.Entities;

namespace Lyu.Core.Domin.Users
{
    public class HrInfo : Entity<int>
    {
        public string Department { get; set; } // HrDepartment
        public string DepartmentCode { get; set; } // HrDepartmentCode
        public string Name { get; set; } // HrName
        public string Code { get; set; } // HrCode
        public string Photo { get; set; } // HrPhoto
        public string Sex { get; set; } // HrSex
        public string Office { get; set; } // HrOffice
        public string Birthday { get; set; } // HrBirthday
        public string Record { get; set; } // HrRecord
        public string School { get; set; } // HrSchool
        public string EndDate { get; set; } // HrEndDate
        public string IdNumber { get; set; } // HrIDnumber
        public string FamilyAddress { get; set; } // HrFamilyAddress
        public string Address { get; set; } // HrAddress
        public DateTime? Date { get; set; } // HrDate1
        public string GgreementDate { get; set; } // HrGgreementDate
        public string Phone { get; set; } // HrPhone
        public string Email { get; set; } // HrEmail
        public string Details { get; set; } // HrDetails
        public string State { get; set; } // HrState
        public string EndTime { get; set; } // HrEndTime
        public string EndReason { get; set; } // HrEndReason
        public int? RegId { get; set; } // RegId
        public int HrDepartmentId { get; set; } // HrDepartmentId
        public string State2 { get; set; } // HrState2
        public string Office2 { get; set; } // HrOffice2
        public string Office3 { get; set; } // HrOffice3
        //[ForeignKey("HrDepartmentId")]
        public virtual Department HrDepartment { get; set; }
    }
}