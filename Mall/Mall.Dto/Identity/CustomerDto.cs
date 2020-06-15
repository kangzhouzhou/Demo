using Mall.Aggregate.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Identity
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public ClientType ClientType { get; set; }
    }
}
