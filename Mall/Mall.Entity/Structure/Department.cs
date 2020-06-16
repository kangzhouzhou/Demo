﻿using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.ValueObject;
using Mall.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Entity.Structure
{
    public class Department: BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 上级部门，0表示顶级部门
        /// </summary>
        public int PartenDepartmentId { get; set; }

        /// <summary>
        /// 组织Id
        /// </summary>
        public  int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }

        public virtual List<DepartmentCustomerRelation>  DepartmentCustomerRelationList { get; set; }
    }
}