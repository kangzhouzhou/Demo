﻿using Mall.Entity.Structure;
using Mall.Persistent;
using Mall.Utility.Encryption;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mall.PersistentImpl
{
    public class DbInitPersitent : InitPersitent
    {
        public DbInitPersitent(MallDbContext context)
        {
            _context = context;
        }

        private readonly MallDbContext _context;

        public void Init()
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
                DbSet<Organization> organizationDb = _context.Set<Organization>();
                if (!organizationDb.Any())
                {
                    Organization organization = new Organization();
                    organization.Name = "Mall";

                    Department department = new Department();
                    department.Name = "DeptRoot";
                    organization.DepartmentList = new List<Department>();
                    organization.DepartmentList.Add(department);

                    Customer customer = new Customer();
                    customer.Name = "root";
                    customer.Account = "root";
                    customer.Password = MD5Utility.Encrypt32UpCase(MD5Utility.Encrypt32UpCase("root"));
                    organization.CustomerList = new List<Customer>();
                    organization.CustomerList.Add(customer);

                    organizationDb = _context.Set<Organization>();
                    organizationDb.Add(organization);

                    DepartmentCustomerRelation relation = new DepartmentCustomerRelation();
                    relation.Customer = customer;
                    relation.Department = department;

                    _context.Set<DepartmentCustomerRelation>().Add(relation);

                    _context.SaveChanges();
                }
            }
        }
    }
}
