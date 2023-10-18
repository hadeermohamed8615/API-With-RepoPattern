using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BL.DTOs
{
    public class EmployeeDTO
    {
        
        public int employeeID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string departmentName { get; set; }
    }
}
