using LinkDev.IKEA.DAL.Enteties.Department;
using LinkDev.IKEA.DAL.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Data.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D=>D.Id).UseIdentityColumn(10,10);
            builder.Property(D => D.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(D => D.Code).HasColumnType("varchar(20)").IsRequired();

            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GetUTCDate()");
            builder.Property(D => D.ModifiedOn).HasComputedColumnSql("GetDate()");

            //builder.Property(D => D.CreatedBy).HasDefaultValueSql("");
            //builder.Property(D => D.ModifiedBy).HasDefaultValueSql("");

        }
    }
}
