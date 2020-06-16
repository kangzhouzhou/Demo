using Mall.Aggregate.Structure.Aggregate;
using Mall.Aggregate.Structure.Entity;
using Mall.Entity.Structure;
using Mall.Persistent;
using Mall.Repository.Base;
using Mall.Repository.Structure;
using MMall.RespositoryImpl.Base;
using RobotMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mall.Repostitory.Structure
{
    public class CustomerResponsitorpy : Responsitory<CustomerAggregate>, ICustomerResponsitory
    {
        public CustomerResponsitorpy(IPersistent<Customer> customerPersistent, IPersistent<Department> departmentPersistent, IPersistent<Organization> organizationPersistent)
        {
            _customerPersistent = customerPersistent;
            _departmentPersistent = departmentPersistent;
            _organizationPersistent = organizationPersistent;

        }

        private readonly IPersistent<Customer> _customerPersistent;

        private readonly IPersistent<Department> _departmentPersistent;

        private readonly IPersistent<Organization> _organizationPersistent;

        public CustomerAggregate GetByAccount(string account)
        {
            Customer customer = _customerPersistent.Find(x => x.Account == account).FirstOrDefault();
            if (customer != null)
            {
                Organization organization = _organizationPersistent.Get(customer.OrganizationId);
                List<Department> department = _departmentPersistent.Find(x => customer.DepartmentCustomerRelationList.Select(x => x.DepartmentId).Contains(x.Id)).ToList();
                CustomerEntity customerEntity=customer.RobotMap<Customer, CustomerEntity>();
                OrganizationEntity organizationEntity = organization.RobotMap<Organization, OrganizationEntity>();
                List<DepartmentEntity> departmentEntityList = department.RobotMap<Department, DepartmentEntity>();
                return new CustomerAggregate(customerEntity, organizationEntity, departmentEntityList);
            }
            else
            {
                return null;
            }
        }
    }
}
