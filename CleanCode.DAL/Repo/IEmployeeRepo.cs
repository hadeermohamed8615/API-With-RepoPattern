using CleanCode.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.DAL.Repo
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetAll();
        Employee GetByID(int id);
    }
}
