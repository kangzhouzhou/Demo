using Mall.Aggregate.Base;
using Mall.Aggregate.Structure.Entity;
using RobotMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.Aggregate
{
    public class CustomerAggregate : AggregateRoot<CustomerEntity>
    {
        public CustomerAggregate()
        { 
        
        }

        public CustomerAggregate(CustomerEntity customerEntity, OrganizationEntity organizationEntity, List<DepartmentEntity> departmentEntitieList)
        {
            KeyValue = customerEntity;
            Id = customerEntity.Id;
            Name = customerEntity.Name;
            Account = customerEntity.Account;
            Password = customerEntity.Password;
            IsAdministrator = customerEntity.IsAdministrator;
            IsEnable = customerEntity.IsEnable;
            IsVisible = customerEntity.IsVisible;
            DepartmentList = departmentEntitieList;
            OrganizationId = customerEntity.OrganizationId;
            Organization = organizationEntity;
            OrganizationName = organizationEntity.Name;
            OrganizationIsEnable = organizationEntity.IsEnable;
        }

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

        public List<DepartmentEntity> DepartmentList { get; private set; }

        public OrganizationEntity Organization { get; private set; }

        public int OrganizationId { get; private set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrganizationName { get; private set; }

        public bool OrganizationIsEnable { get; private set; }
    }
}
