using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.Entity;
using Mall.Aggregate.Structure.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.Aggregate
{
    /// <summary>
    /// 聚合,集合根-OrganizationEntity
    /// </summary>
    public class OrganizationAggregate : AggregateRoot<OrganizationEntity>
    {
        public int Id { get { return KeyValue.Id; } set { KeyValue.Id = value; } }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string Name { get { return KeyValue.Name; }set{ KeyValue.Name = value; } }

        /// <summary>
        /// 上级组织，0表示顶级部门
        /// </summary>
        public int ParentOrganizationId { get { return KeyValue.ParentOrganizationId; } set { KeyValue.ParentOrganizationId = value; } }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get { return KeyValue.IsEnable; } set { KeyValue.IsEnable = value; } }

        public List<CustomerEntity> CustomerList { get; set; }

        public List<DepartmentEntity> DepartmentList { get; set; }

        /// <summary>
        /// 第三方映射
        /// </summary>
        public List<ThirdPartyOrgMapEntity> ThirdPartyOrgMapList { get; set; }
    }
}
