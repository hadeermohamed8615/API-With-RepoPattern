using CleanCode.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BL.Mangers
{
    public interface IEmployeeManger
    {
        IEnumerable<EmployeeDTO> GetAll();
        EmployeeDTO Get(int id);
    }
}
