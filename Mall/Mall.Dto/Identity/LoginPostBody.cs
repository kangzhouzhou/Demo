using Mall.Dto.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Mall.Dto.Identity
{
    public class LoginPostBody
    {
        [JsonProperty("UserName")]
        public string Account { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
