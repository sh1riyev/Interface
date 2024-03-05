using System;
using Practice_Interface_Services.Models;

namespace Practice_Interface_Services.Helpers.Responses
{
	public class EmployeeResponse 
	{
		public Employee Employee { get; set; }
		public string ErrorMessage{ get; set; }
		public Employee[] Employees { get; set; }
	}
}

