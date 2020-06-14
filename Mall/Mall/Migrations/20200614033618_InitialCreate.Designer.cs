﻿// <auto-generated />
using System;
using Mall.PersistentImpl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mall.PersistentImpl.Migrations
{
    [DbContext(typeof(MallDbContext))]
    [Migration("20200614033618_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mall.Entity.Structure.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 6, 14, 11, 36, 17, 148, DateTimeKind.Local).AddTicks(2158));

                    b.Property<int>("Creater")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleter")
                        .HasColumnType("int");

                    b.Property<int>("EntityStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Mall.Entity.Structure.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 6, 14, 11, 36, 17, 145, DateTimeKind.Local).AddTicks(1580));

                    b.Property<int>("Creater")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleter")
                        .HasColumnType("int");

                    b.Property<int>("EntityStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("PartenDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Mall.Entity.Structure.DepartmentCustomerRelation", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("CustomerId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentCustomerRelation");
                });

            modelBuilder.Entity("Mall.Entity.Structure.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 6, 14, 11, 36, 17, 128, DateTimeKind.Local).AddTicks(6276));

                    b.Property<int>("Creater")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleter")
                        .HasColumnType("int");

                    b.Property<int>("EntityStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentOrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("Mall.Entity.Structure.ThirdPartyOrgMap", b =>
                {
                    b.Property<string>("ThirdPartyOrgId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ThirdPartyApp")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("PermanentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyAppId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyAppName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyOrgName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThirdPartyOrgId", "ThirdPartyApp");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ThirdPartyOrgMap");
                });

            modelBuilder.Entity("Mall.Entity.Structure.Customer", b =>
                {
                    b.HasOne("Mall.Entity.Structure.Organization", "Organization")
                        .WithMany("CustomerList")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mall.Entity.Structure.Department", b =>
                {
                    b.HasOne("Mall.Entity.Structure.Organization", "Organization")
                        .WithMany("DepartmentList")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mall.Entity.Structure.DepartmentCustomerRelation", b =>
                {
                    b.HasOne("Mall.Entity.Structure.Customer", "Customer")
                        .WithMany("DepartmentCustomerRelationList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mall.Entity.Structure.Department", "Department")
                        .WithMany("DepartmentCustomerRelationList")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Mall.Entity.Structure.ThirdPartyOrgMap", b =>
                {
                    b.HasOne("Mall.Entity.Structure.Organization", "Organization")
                        .WithMany("ThirdPartyOrgMapList")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
