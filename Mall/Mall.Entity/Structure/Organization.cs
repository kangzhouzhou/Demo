
using Mall.IEntity.Base;
using Mall.IEntity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Structure
{
    public class Organization : IntEntity, IEntityStatus, IEntityVisible, IEntityEnable
    {
        /// <summary>
        /// 组织名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 上级组织，0表示顶级部门
        /// </summary>
        public int ParentOrganizationId { get; set; }

        /// <summary>
        /// 集合导航属性
        /// </summary>
        public virtual List<Department> DepartmentList { get; set; }

        public virtual List<Customer> CustomerList { get; set; }

        public virtual List<ThirdPartyOrgMap> ThirdPartyOrgMapList { get; set; }

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
