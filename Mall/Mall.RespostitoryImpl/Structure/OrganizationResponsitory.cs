using Mall.Aggregate.Structure.Aggregate;
using Mall.Aggregate.Structure.Entity;
using Mall.Entity.Structure;
using Mall.Persistent;
using Mall.Repository.Structure;
using MMall.RespositoryImpl.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.RespositoryImpl.Structure
{
    public class OrganizationResponsitory : Responsitory<OrganizationAggregate>, IOrganizationResponsitory
    {
        public OrganizationResponsitory(IPersistent<Customer> customerPersistent, IPersistent<Department> departmentPersistent, IPersistent<Organization> organizationPersistent)
        { 
            
        }
    }
}
