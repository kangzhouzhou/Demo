using Mall.Dto.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Identity
{
    public class LoginPostBody
    {
        [JsonProperty("UserName")]
        public string Account { get; set; }

        public string Password { get; set; }
    }
}
