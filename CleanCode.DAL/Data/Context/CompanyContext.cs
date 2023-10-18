using CleanCode.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanCode.DAL.Data.Context
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions o) : base(o)
        {

        }
        public virtual DbSet<Employee> employees { get; set; }
        public virtual DbSet<Department> department { get; set; }
    }
}
