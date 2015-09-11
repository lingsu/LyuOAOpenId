using Lyu.Core.Domin.Users;

namespace Lyu.EntityFramework.Configuration.Users
{
    public class HrInfoMap : NopEntityTypeConfiguration<HrInfo>
    {
        public HrInfoMap()
        {
            ToTable("HrTable");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("HrId").IsRequired().HasColumnType("int");
            Property(x => x.Department).HasColumnName("HrDepartment").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.DepartmentCode).HasColumnName("HrDepartmentCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(53);
            Property(x => x.Name).HasColumnName("HrName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Code).HasColumnName("HrCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(53);
            Property(x => x.Photo).HasColumnName("HrPhoto").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Sex).HasColumnName("HrSex").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Office).HasColumnName("HrOffice").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Birthday).HasColumnName("HrBirthday").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Record).HasColumnName("HrRecord").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.School).HasColumnName("HrSchool").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.EndDate).HasColumnName("HrEndDate").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.IdNumber).HasColumnName("HrIDnumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.FamilyAddress).HasColumnName("HrFamilyAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Address).HasColumnName("HrAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Date).HasColumnName("HrDate1").IsOptional().HasColumnType("datetime");
            Property(x => x.GgreementDate).HasColumnName("HrGgreementDate").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Phone).HasColumnName("HrPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Email).HasColumnName("HrEmail").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Details).HasColumnName("HrDetails").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.State).HasColumnName("HrState").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EndTime).HasColumnName("HrEndTime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EndReason).HasColumnName("HrEndReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.RegId).HasColumnName("RegId").IsOptional().HasColumnType("int");
            Property(x => x.HrDepartmentId).HasColumnName("HrDepartmentId").IsRequired().HasColumnType("int");
            Property(x => x.State2).HasColumnName("HrState2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Office2).HasColumnName("HrOffice2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Office3).HasColumnName("HrOffice3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);

            this.HasRequired(x => x.HrDepartment).WithMany(l => l.HrInfos)
                .HasForeignKey(x => x.HrDepartmentId);
            //    //.Map(x=>x.MapKey("HrDepartmentId"));
            //   .HasForeignKey(x => x.HrDepartmentId);

        }
    }
}