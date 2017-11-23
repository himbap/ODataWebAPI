using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODataWebAPI.Models
{
    public class Employee
    {
        [Key]
        public Guid Empid { get; set; }
        public String EName { get; set; }
        public String Department { get; set; }
    }
}