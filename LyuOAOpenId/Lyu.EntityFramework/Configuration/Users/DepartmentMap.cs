using Lyu.Core.Domin.Users;

namespace Lyu.EntityFramework.Configuration.Users
{
    public class DepartmentMap : NopEntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            ToTable("HrDepartmentTable");
            HasKey(x => x.Id);

            //HasMany(x=>x.HrInfos).

            Property(x => x.Id).HasColumnName("HrDepartmentId").IsRequired().HasColumnType("int");
            Property(x => x.CompanyId).HasColumnName("CompanyId").IsRequired().HasColumnType("int");
            Property(x => x.HrDepartment).HasColumnName("HrDepartment").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HrDepartment2).HasColumnName("HrDepartment2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HrDepartmentCode).HasColumnName("HrDepartmentCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HrDepartmentCount).HasColumnName("HrDepartmentCount").IsOptional().HasColumnType("int");
            Property(x => x.DelFlag).HasColumnName("DelFlag").HasColumnType("bit");
            Property(x => x.TopId).HasColumnName("TopId").HasColumnType("int");
            Property(x => x.TopHr).HasColumnName("TopHr").IsOptional().HasColumnType("int");
            Property(x => x.TopId2).HasColumnName("TopId2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HrDepartmentBoss).HasColumnName("HrDepartmentBoss").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HrDepartmentBoss2).HasColumnName("HrDepartmentBoss2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Tj).HasColumnName("Tj").IsOptional().HasColumnType("bit");
            Property(x => x.Tj2).HasColumnName("Tj2").IsOptional().HasColumnType("bit");
            Property(x => x.HrDepartment3).HasColumnName("HrDepartment3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SortId).HasColumnName("SortId").IsOptional().HasColumnType("int");
            Property(x => x.HrDepartmentC).HasColumnName("HrDepartmentC").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(25);
            Property(x => x.Zhuguan).HasColumnName("zhuguan").IsOptional().HasColumnType("int");
            Property(x => x.JinLi).HasColumnName("JinLi").IsOptional().HasColumnType("int");
            Property(x => x.ZongJian).HasColumnName("ZongJian").IsOptional().HasColumnType("int");
            Property(x => x.ZuiGao).HasColumnName("ZuiGao").IsOptional().HasColumnType("int");
            Property(x => x.FShangBao).HasColumnName("F_shangBao").IsOptional().HasColumnType("int");
            Property(x => x.FShengHe).HasColumnName("F_shengHe").IsOptional().HasColumnType("int");
            //Property(x => x.DeContent).HasColumnName("DeContent").IsOptional().HasColumnType("ntext").HasMaxLength(1073741823);
            Property(x => x.CompanyDgJid).HasColumnName("companyDGJid").IsOptional().HasColumnType("int");
        }
    }
}