using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int id { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public decimal  Salary { get; set; }
    }
}
