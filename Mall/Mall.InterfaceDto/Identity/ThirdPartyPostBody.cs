using Mall.InterfaceDto.Base;
using Mall.InterfaceDto.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mall.InterfaceDto.Identity
{
    public class ThirdPartyPostBody : PostRequestBody
    {
        public ClientType State { get; set; }

        public string Code { get; set; }

        public string Auth_Code { get; set; }
    }
}
