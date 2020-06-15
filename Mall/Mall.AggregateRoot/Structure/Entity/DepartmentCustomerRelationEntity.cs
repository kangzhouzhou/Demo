using Mall.Aggregate.Base;
using Mall.Aggregate.Enums;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.ValueObject
{
    /// <summary>
    /// 人员部门关系
    /// </summary>
    public class DepartmentCustomerRelationEntity : Entity<DepartmentCustomerRelationKey>
    {
        public int DepartmentId
        {
            get { return KeyValue.DepartmentId; }
            set { KeyValue.DepartmentId = value; }
        }

        public int CustomerId
        {
            get { return KeyValue.CustomerId; }
            set { KeyValue.CustomerId = value; }
        }

        public CustomerRole CustomerRole { get; set; }
    }
}
