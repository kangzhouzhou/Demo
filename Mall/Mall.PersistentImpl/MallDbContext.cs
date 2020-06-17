using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Mall.Aggregate.Structure.Entity;
using Mall.Entity.Structure;
using Mall.Entity.Base;
using Mall.Aggregate.Enums;

namespace Mall.PersistentImpl
{
    public class MallDbContext : DbContext
    {
        public MallDbContext(DbContextOptions<MallDbContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityTypeBuilder<Organization> organizationBuilder = modelBuilder.Entity<Organization>();
            organizationBuilder.ToTable("Organization");
            organizationBuilder.HasKey(x => x.Id);
            organizationBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            organizationBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            organizationBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
            organizationBuilder.HasMany(x => x.DepartmentList).WithOne(x => x.Organization);
            organizationBuilder.HasMany(x => x.CustomerList).WithOne(x => x.Organization);
            organizationBuilder.Property(x => x.IsEnable).HasDefaultValue(true);

            EntityTypeBuilder<Department> departmentBuilder = modelBuilder.Entity<Department>();
            departmentBuilder.HasKey(x => x.Id);
            departmentBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            departmentBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            departmentBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
            departmentBuilder.Property(x => x.IsEnable).HasDefaultValue(true);
            departmentBuilder.Property(x => x.IsVisible).HasDefaultValue(true);

            EntityTypeBuilder<Customer> customerBuilder = modelBuilder.Entity<Customer>();
            customerBuilder.HasKey(x => x.Id);
            customerBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            customerBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            customerBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
            customerBuilder.HasOne(x => x.Organization).WithMany(x => x.CustomerList);
            customerBuilder.HasIndex(x => new { x.Account }).IsUnique();
            customerBuilder.Property(x => x.IsEnable).HasDefaultValue(true);
            customerBuilder.Property(x => x.IsVisible).HasDefaultValue(true);
            customerBuilder.HasMany(x => x.DepartmentCustomerRelationList).WithOne(x => x.Customer);

            EntityTypeBuilder<DepartmentCustomerRelation> departmentCustomerRelationBuilder = modelBuilder.Entity<DepartmentCustomerRelation>();
            departmentCustomerRelationBuilder.HasKey(x => new { x.CustomerId, x.DepartmentId });
            departmentCustomerRelationBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            departmentCustomerRelationBuilder.HasOne(x => x.Department).WithMany(x => x.DepartmentCustomerRelationList).HasForeignKey(x=>x.DepartmentId).OnDelete(DeleteBehavior.Restrict);
            departmentCustomerRelationBuilder.HasOne(x => x.Customer).WithMany(x => x.DepartmentCustomerRelationList).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            departmentCustomerRelationBuilder.Property(x => x.CustomerRole).HasDefaultValue(CustomerRole.Staff);
            departmentCustomerRelationBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            departmentCustomerRelationBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);

            EntityTypeBuilder<ThirdPartyOrgMap> thirdPartyOrgMapBuilder= modelBuilder.Entity<ThirdPartyOrgMap>();
            thirdPartyOrgMapBuilder.HasKey(x =>new { x.ThirdPartyOrgId, x.ThirdPartyApp });
            thirdPartyOrgMapBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            thirdPartyOrgMapBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Organization> Organization { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<DepartmentCustomerRelation> DepartmentCustomerRelation { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<ThirdPartyOrgMap> ThirdPartyOrgMap { get; set; }
    }
}
