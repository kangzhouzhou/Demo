using Mall.Aggregate.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.ValueObject
{
    public class ThirdPartyOrgMapKey
    {
        /// <summary>
        /// 组织第三方映射
        /// </summary>
        public string ThirdPartyOrgId { get; set; }

        public ThirdPartyApp ThirdPartyApp { get; set; }
    }
}
