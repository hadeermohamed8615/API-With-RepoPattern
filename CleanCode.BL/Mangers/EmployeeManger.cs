using CleanCode.BL.DTOs;
using CleanCode.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BL.Mangers
{
    public class EmployeeManger : IEmployeeManger
    {
        IEmployeeRepo repo;
        public EmployeeManger(IEmployeeRepo _repo)
        {
            repo = _repo;
        }

        public EmployeeDTO Get(int id)
        {
            EmployeeDTO dto = new EmployeeDTO();
             var em = repo.GetByID(id);
            if(em != null) { dto.name = em.name; }
            return dto;
        }

        public IEnumerable<EmployeeDTO> GetAll()
        {
          var Emps=  repo.GetAll();
            List<EmployeeDTO> Employees = new List<EmployeeDTO>();
            foreach(var item in Emps) {
                EmployeeDTO em = new EmployeeDTO()
                {
                    employeeID = item.id,
                    age = item.age,
                    name = item.name,
                    departmentName = item.dept.name
                };

                Employees.Add(em);
            }

           

            return Employees;

        }
    }
}
