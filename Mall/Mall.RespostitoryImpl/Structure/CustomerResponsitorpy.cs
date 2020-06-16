using Mall.Aggregate.Structure.Aggregate;
using Mall.Aggregate.Structure.Entity;
using Mall.Entity.Structure;
using Mall.Persistent;
using Mall.Repository.Base;
using Mall.Repository.Structure;
using MMall.RespositoryImpl.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Repostitory.Structure
{
    public class CustomerResponsitorpy : Responsitory<CustomerAggregate>, ICustomerResponsitory
    {
        public CustomerResponsitorpy(IPersistent<Customer> customerPersistent, IPersistent<Department> departmentPersistent, IPersistent<Organization> organizationPersistent)
        {
        }

        public CustomerAggregate GetByAccount(string account)
        {
            throw new NotImplementedException();
        }
    }
}
