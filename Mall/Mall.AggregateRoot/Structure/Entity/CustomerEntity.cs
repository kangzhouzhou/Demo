using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.Entity
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class CustomerEntity : IntEntity, IsEnable, IsVisible
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
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }

        public int OrganizationId { get; private set; }
    }
}
