using Mall.Aggregate.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mall.Dto.Identity
{
    public class ThirdPartyPostBody
    {
        public ClientType State { get; set; }

        public string Code { get; set; }

        public string Auth_Code { get; set; }
    }
}
