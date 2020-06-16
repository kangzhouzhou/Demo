using Mall.Aggregate.Structure.Aggregate;
using Mall.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Repository.Structure
{
    public interface ICustomerResponsitory : IResponsitory<CustomerAggregate>
    {
        CustomerAggregate GetByAccount(string account);
    }
}
