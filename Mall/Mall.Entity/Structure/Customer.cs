using Mall.IEntity.Base;
using Mall.IEntity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Structure
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class Customer : IntEntity, IEntityStatus, IEntityVisible, IEntityEnable
    {
        public string Name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 是否为管理员
        /// </summary>
        public bool IsAdministrator { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public int OrganizationId { get; set; }

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
