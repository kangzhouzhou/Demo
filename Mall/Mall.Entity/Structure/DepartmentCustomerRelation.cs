using Mall.Aggregate.Enums;
using Mall.Entity.Base;


namespace Mall.Entity.Structure
{
    /// <summary>
    /// 人员部门关系
    /// </summary>
    public class DepartmentCustomerRelation : BaseEntity
    {
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public CustomerRole CustomerRole { get; set; }
    }
}
