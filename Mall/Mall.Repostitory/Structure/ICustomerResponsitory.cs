using Mall.AggregateRoot;
using Mall.IEntity.Structure;
using Mall.Persistent;
using Mall.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Repository.Structure
{
    public interface ICustomerResponsitory : IResponsitory<CustomerAR>
    {
        CustomerAR GetByAccount(string account);
    }
}
