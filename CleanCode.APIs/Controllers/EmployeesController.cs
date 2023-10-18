using CleanCode.BL.DTOs;
using CleanCode.BL.Mangers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCode.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeManger employeeManger;

        public EmployeesController(IEmployeeManger _employeeManger)
        {
            employeeManger = _employeeManger;
        }
        [HttpGet]
        public ActionResult getAll()
        {
            List<EmployeeDTO> emps = employeeManger.GetAll().ToList();
            if(emps == null) { return NotFound(); }
            return Ok(emps) ;
        }
        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            return Ok(employeeManger.Get(id));
        }
    }
}
