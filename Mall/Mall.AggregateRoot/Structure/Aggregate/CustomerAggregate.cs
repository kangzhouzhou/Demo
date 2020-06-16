using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.Aggregate
{
    public class CustomerAggregate : AggregateRoot<CustomerEntity>
    { 
        public int Id { get; set; }

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
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }

        public int OrganizationId { get; private set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrganizationName { get; private set; }
    }
}
