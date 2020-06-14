using Mall.IEntity.Base;
using Mall.IEntity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Structure
{
    /// <summary>
    /// 人员部门关系
    /// </summary>
    public class DepartmentCustomerRelation : BaseEntity<DepartmentCustomerRelationKey>
    {
        public int DepartmentId
        {
            get { return Key.DepartmentId; }
            set { Key.DepartmentId = value; }
        }

        public virtual Department Department { get; set; }

        public int CustomerId
        {
            get { return Key.CustomerId; }
            set { Key.CustomerId = value; }
        }

        public virtual Customer Customer { get; set; }

        public CustomerRole CustomerRole { get; set; }
    }
}
