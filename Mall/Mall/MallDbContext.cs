using Mall.IEntity.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Mall.IEntity.Enums;

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
            organizationBuilder.HasKey(x => x.Id);
            organizationBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            organizationBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            organizationBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
            organizationBuilder.HasMany(x => x.DepartmentList).WithOne(x => x.Organization);
            organizationBuilder.HasMany(x => x.CustomerList).WithOne(x => x.Organization);


            EntityTypeBuilder<Department> departmentBuilder = modelBuilder.Entity<Department>();
            departmentBuilder.HasKey(x => x.Id);
            departmentBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            departmentBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            departmentBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);

            EntityTypeBuilder<Customer> customerBuilder = modelBuilder.Entity<Customer>();
            customerBuilder.HasKey(x => x.Id);
            customerBuilder.HasQueryFilter(x => x.EntityStatus != EntityStatus.Deleted);
            customerBuilder.Property(x => x.EntityStatus).HasDefaultValue(EntityStatus.Normal);
            customerBuilder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
            customerBuilder.HasOne(x => x.Organization).WithMany(x => x.CustomerList);
            customerBuilder.HasIndex(x => new { x.Account }).IsUnique();

            EntityTypeBuilder<DepartmentCustomerRelation> departmentCustomerRelationBuilder = modelBuilder.Entity<DepartmentCustomerRelation>();
            departmentCustomerRelationBuilder.HasKey(x => new { x.CustomerId, x.DepartmentId });
            departmentCustomerRelationBuilder.HasOne(x => x.Department).WithMany(x => x.DepartmentCustomerRelationList).OnDelete(DeleteBehavior.Restrict);
            departmentCustomerRelationBuilder.HasOne(x => x.Customer).WithMany(x => x.DepartmentCustomerRelationList).OnDelete(DeleteBehavior.Restrict);
            departmentCustomerRelationBuilder.Property(x => x.CustomerRole).HasDefaultValue(CustomerRole.Staff);

            EntityTypeBuilder<ThirdPartyOrgMap> thirdPartyOrgMapBuilder= modelBuilder.Entity<ThirdPartyOrgMap>();
            thirdPartyOrgMapBuilder.HasKey(x =>new { x.ThirdPartyOrgId, x.ThirdPartyApp });
            
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
