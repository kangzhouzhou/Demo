using Mall.IEntity.Base;
using Mall.IEntity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Structure
{
    public class Department : IntEntity, IEntityStatus, IEntityVisible, IEntityEnable
    {
        public string Name { get; set; }

        /// <summary>
        /// 上级部门，0表示顶级部门
        /// </summary>
        public int PartenDepartmentId { get; set; }

        /// <summary>
        /// 组织Id
        /// </summary>
        public virtual int OrganizationId { get; set; }

        /// <summary>
        /// 导航属性
        /// </summary>
        public virtual Organization Organization { get; set; }

        public virtual List<DepartmentCustomerRelation> DepartmentCustomerRelationList { get; set; } 

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public int Creater { get; set; }

        public DateTime CreateTime { get; set; }

        public int Deleter { get; set; }

        public DateTime DeleteTime { get; set; }
    }
}
