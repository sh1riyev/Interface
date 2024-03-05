using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;

namespace Practice_Interface_Services.Services.Interfaces
{
	public interface IEmployeeService
	{
        public Employee[] GetAll();
        public EmployeeResponse GetById(Employee[]employess,int ? id);
        public EmployeeResponse SearchMethod(Employee[]employees,string search);
    }
}

