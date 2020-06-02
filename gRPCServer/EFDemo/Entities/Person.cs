using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFConsole.Entities
{
    public class Person
    {
        [Key]
        public string Guid { get; set; }
    }
}
