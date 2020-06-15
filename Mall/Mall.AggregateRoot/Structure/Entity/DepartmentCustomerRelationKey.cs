using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.ValueObject
{
    public class DepartmentCustomerRelationKey
    {
        public int DepartmentId { get; set; }

        public int CustomerId { get; set; }
    }
}
