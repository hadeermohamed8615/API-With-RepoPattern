using CleanCode.DAL.Data.Context;
using CleanCode.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.DAL.Repo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        CompanyContext context;
        public EmployeeRepo(CompanyContext _context)
        {
            context = _context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return context.employees.Include(d=>d.dept).ToList();
        }

        public Employee GetByID(int id)
        {
            return context.employees.Find(id);
        }
    }
}
