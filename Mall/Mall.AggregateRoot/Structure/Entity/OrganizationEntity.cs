
using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.Entity
{
    public class OrganizationEntity : IntEntity, IsEnable
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
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
