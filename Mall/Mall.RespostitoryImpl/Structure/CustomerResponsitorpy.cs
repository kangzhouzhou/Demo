using Mall.AggregateRoot;
using Mall.IEntity.Structure;
using Mall.Persistent;
using Mall.Repository.Base;
using Mall.Repository.Structure;
using MMall.RespositoryImpl.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Repostitory.Structure
{
    public class CustomerResponsitorpy: Responsitory<CustomerAR>, ICustomerResponsitory
    {
        public CustomerResponsitorpy(IPersistent<Customer> persistent)
            : base(persistent)
        {
        }

        public void Add(CustomerAR entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CustomerAR> entityCollection)
        {
            throw new NotImplementedException();
        }
    }
}
